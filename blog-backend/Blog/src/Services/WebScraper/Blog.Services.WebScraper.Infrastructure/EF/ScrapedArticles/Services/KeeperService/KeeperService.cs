using System.Net;
using System.Text.RegularExpressions;
using Blog.Services.Common.Abstractions.Time;
using Blog.Services.WebScraper.Application.ScrapedArticles.Services;
using Blog.Services.WebScraper.Domain.ScrapedArticles.Entities;
using Blog.Services.WebScraper.Domain.ValueObjects.Provider;
using HtmlAgilityPack;
using Microsoft.Extensions.Configuration;

namespace Blog.Services.WebScraper.Infrastructure.EF.ScrapedArticles.Services.KeeperService
{
    public class KeeperService : IWebScraperService
    {
        public string Name => "Keeper";
        public string SectionName => "keeperKeywords";
        private const string BaseUrl = "https://www.keepersecurity.com/blog/pl/";
        private const string PaginationUrl = "https://www.keepersecurity.com/blog/pl/page";
        private const int MaxPages = 999;
        private readonly HtmlWeb _html;
        private List<ScrapeArticle> _scrapeArticles = new List<ScrapeArticle>();

        private readonly IConfiguration _configuration;
        private readonly IClock _clock;

        public KeeperService(IConfiguration configuration, IClock clock)
        {
            _html = new HtmlWeb { OverrideEncoding = System.Text.Encoding.UTF8 };
            _configuration = configuration;
            _clock = clock;
        }

        public List<ScrapeArticle> ScrapData() //d
        {
            ScrapFirstPage();
            ScrapPaginatePages();
            return _scrapeArticles;
        }

        private void ScrapFirstPage()
        {
            var page = _html.Load(BaseUrl);
            GetContent(page);
        }

        private void ScrapPaginatePages()
        {
            for (int i = 1; i < MaxPages; i++)
            {
                var page = _html.Load($"{PaginationUrl}/{i}/");
                GetContent(page);
            }
        }

        private void GetContent(HtmlDocument? page)
        {
            var articles = page
                .DocumentNode.Descendants("article")
                .Where(node => node.GetAttributeValue("class", "").Contains("thePost blog-tile"))
                .ToList();

            if (!articles.Any())
                return;

            for (int j = 0; j < articles.Count; j++)
            {
                var article = articles[j];

                var linkNode = article.Descendants("a").FirstOrDefault();

                var href = linkNode.GetAttributeValue("href", "");

                var articleUrl = href.StartsWith("http")
                    ? href
                    : "https://www.keepersecurity.com" + href;

                var articleDoc = _html.Load(articleUrl);

                var articleContent = articleDoc
                    .DocumentNode.Descendants("div")
                    .Where(d => d.GetAttributeValue("class", "").Contains("contentArea"))
                    .SingleOrDefault();

                var formmatedArticleContent = CleanText(articleContent.InnerHtml);

                var articleEntity = ScrapeArticle.Create(
                    formmatedArticleContent,
                    AvailableProviders.GetProvider(Name),
                    _clock.CurrentDateTimeOffset()
                );

                _scrapeArticles.Add(articleEntity);
            }
        }

        private string CleanText(string text)
        {
            var textList = text.Split(" ").ToList();
            var keywords = _configuration.GetSection(SectionName).Get<List<string>>();

            foreach (var keyword in keywords)
            {
                var keywordWords = keyword.Split(" ").ToList();
                var keywordLength = keywordWords.Count;

                for (int i = 0; i <= textList.Count() - keywordLength; i++)
                {
                    var subList = textList.GetRange(i, keywordLength);

                    if (subList.SequenceEqual(keywordWords, StringComparer.OrdinalIgnoreCase))
                    {
                        textList.RemoveRange(i, keywordLength);

                        text = string.Join(" ", textList);

                        i--;
                    }
                }
            }

            text = Regex.Replace(text, @"(\n{3,})", "\n");

            return text;
        }
    }
}
