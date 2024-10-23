using Blog.Services.WebScraper.Domain.ScrapedArticles.Entities;

namespace Blog.Services.WebScraper.Application.ScrapedArticles.Services
{
    public interface IWebScraperService
    {
        public  string Name { get; }
        public List<ScrapeArticle> ScrapData();
    }
}
