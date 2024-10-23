using Blog.Services.Common.Abstractions.Commands;
using Blog.Services.Common.Abstractions.Response;
using Blog.Services.WebScraper.Application.ScrapedArticles.Services.Factories;
using Blog.Services.WebScraper.Domain.ScrapedArticles.Entities;
using Blog.Services.WebScraper.Domain.ScrapedArticles.Repositories;
using Blog.Services.WebScraper.Domain.ValueObjects.Provider;

namespace Blog.Services.WebScraper.Application.ScrapedArticles.Commands.ScrapArticles;

internal sealed class ScrapArticlesHandler(IScraperSeviceFactory scraperSeviceFactory, IScrapedArticlesRepository iscrapedArticlesRepository) : ICommandHandler<ScrapArticlesCommand>
{
   
    public async Task<Result> Handle(ScrapArticlesCommand request, CancellationToken cancellationToken)
    {
        var providers = AvailableProviders.All;
        var scrapedArticles = new List<ScrapeArticle>();
        
        foreach (var provider in providers)
        {
            var scraperfactory =  scraperSeviceFactory.Create(provider);
            scrapedArticles.AddRange( scraperfactory.ScrapData());

        }
         await iscrapedArticlesRepository.AddListAsync(scrapedArticles,cancellationToken);
        return Result.Success();
    }
}
