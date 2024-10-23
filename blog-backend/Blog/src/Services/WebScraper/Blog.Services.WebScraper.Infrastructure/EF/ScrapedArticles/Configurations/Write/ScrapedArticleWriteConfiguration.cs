using Blog.Services.WebScraper.Domain.ScrapedArticles.Entities;
using Blog.Services.WebScraper.Domain.ValueObjects.Provider;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Services.WebScraper.Infrastructure.EF.ScrapedArticles.Configurations.Write
{
    internal class ScrapedArticleWriteConfiguration : IEntityTypeConfiguration<ScrapeArticle>
    {
        public void Configure(EntityTypeBuilder<ScrapeArticle> builder)
        {
            builder.HasKey(q => q.Id);
            builder.OwnsOne<Provider>(
                "Provider",
                type =>
                {
                    type.Property<string>("Value").HasColumnName("Provider");
                }
            );

            builder.ToTable("ScrapeArticles");
        }
    }
}
