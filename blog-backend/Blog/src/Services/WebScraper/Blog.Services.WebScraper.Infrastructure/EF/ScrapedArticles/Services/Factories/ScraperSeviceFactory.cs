using Blog.Services.WebScraper.Application.ScrapedArticles.DTO;
using Blog.Services.WebScraper.Application.ScrapedArticles.Services;
using Blog.Services.WebScraper.Application.ScrapedArticles.Services.Factories;
using Blog.Services.WebScraper.Domain.ScrapedArticles.Entities;
using Blog.Services.WebScraper.Domain.ValueObjects.Provider;
using Blog.Services.WebScraper.Domain.ValueObjects.Provider.Exceptions;
using Blog.Services.WebScraper.Infrastructure.EF.ScrapedArticles.Services.KeeperService;

namespace Blog.Services.WebScraper.Infrastructure.EF.ScrapedArticles.Services.Factories
{
    public sealed class ScraperSeviceFactory : IScraperSeviceFactory
    {
        private readonly IEnumerable<IWebScraperService> _webScraperService;

        public ScraperSeviceFactory(IEnumerable<IWebScraperService> webScraperService)
        {
            _webScraperService = webScraperService;
        }

        public IWebScraperService Create(Provider provider)
        {
            var authServices = _webScraperService.SingleOrDefault(q => q.Name == provider.Value);
            if (authServices is null)
                throw new UnsupportedProviderException($"{provider.Value}");

            return authServices;
        }
    }
}
