using Blog.Services.WebScraper.Domain.ValueObjects.Provider;

namespace Blog.Services.WebScraper.Application.ScrapedArticles.Services.Factories
{
    public interface IScraperSeviceFactory
    {
        public IWebScraperService Create(Provider provider);
    }
}
