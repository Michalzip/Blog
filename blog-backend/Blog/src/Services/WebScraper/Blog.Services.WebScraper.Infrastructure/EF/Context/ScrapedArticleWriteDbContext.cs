using Blog.Services.WebScraper.Domain.ScrapedArticles.Entities;
using Blog.Services.WebScraper.Infrastructure.EF.ScrapedArticles.Configurations.Write;
using Microsoft.EntityFrameworkCore;

namespace Blog.Services.WebScraper.Infrastructure.EF.Context;
internal sealed class ScrapedArticleWriteDbContext : DbContext
{
    public DbSet<ScrapeArticle> ScrapeArticles { get; set; }
    
    public ScrapedArticleWriteDbContext(DbContextOptions<ScrapedArticleWriteDbContext> options)
        : base(options) { }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ScrapedArticleWriteConfiguration());
    }
}
