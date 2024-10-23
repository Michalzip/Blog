using System.Diagnostics.CodeAnalysis;
using Blog.Services.Common.Abstractions.Kernel;
using Blog.Services.WebScraper.Domain.ValueObjects.Provider;

namespace Blog.Services.WebScraper.Domain.ScrapedArticles.Entities
{
    public class ScrapeArticle : Entity
    {
        public ScrapeArticle() { }

        public Guid Id { get; set; }
        public string Text { get; set; }
        public bool IsAlreadyUsed { get; set; }

        [MaybeNull]
        private Provider? Provider { get; set; }
        private DateTimeOffset CreatedAt { get; set; }

        private ScrapeArticle(DateTimeOffset createdAt)
        {
            CreatedAt = createdAt;
            IsAlreadyUsed = false;
        }

        public static ScrapeArticle Create(
            string text,
            Provider provider,
            DateTimeOffset createdAt
        ) =>
            new(createdAt)
            {
                Id = Guid.NewGuid(),
                Text = text,
                IsAlreadyUsed = false,
                Provider = provider
            };
    }
}
