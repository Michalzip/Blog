using Blog.Services.Common.Infrastructure.Postgres;
using Blog.Services.WebScraper.Infrastructure.EF.Context;

namespace Blog.Services.WebScraper.Domain.UnitOfWork;

internal class ScrapeArticlesUnitOfWork : PostgresUnitOfWork<ScrapedArticleWriteDbContext>
{
    public ScrapeArticlesUnitOfWork(ScrapedArticleWriteDbContext writeContext) : base(writeContext)
    {
    }
}