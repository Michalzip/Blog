namespace Blog.Services.WebScraper.Domain.ScrapedArticles.Repositories;

using Blog.Services.WebScraper.Domain.ScrapedArticles.Entities;

public interface IScrapedArticlesRepository
{
    Task AddListAsync(List<ScrapeArticle> scrapeArticles, CancellationToken cancellationToken);
}
