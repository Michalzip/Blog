using Blog.Services.WebScraper.Domain.ScrapedArticles.Entities;
using Blog.Services.WebScraper.Domain.ScrapedArticles.Repositories;
using Blog.Services.WebScraper.Infrastructure.EF.Context;

namespace Blog.Services.WebScraper.Infrastructure.EF.ScrapedArticles.Repositories;

internal sealed class ScrapedArticlesRepository(ScrapedArticleWriteDbContext dbContext)
    : IScrapedArticlesRepository
{
    public async Task AddListAsync(
        List<ScrapeArticle> scrapeArticles,
        CancellationToken cancellationToken
    )
    {
        await dbContext.ScrapeArticles.AddRangeAsync(scrapeArticles, cancellationToken);
        await dbContext.SaveChangesAsync(cancellationToken);
    }
}
