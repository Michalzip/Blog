using Blog.Services.WebScraper.Application.ScrapedArticles.Services;
using Blog.Services.WebScraper.Application.ScrapedArticles.Services.Factories;
using Blog.Services.WebScraper.Domain.ScrapedArticles.Repositories;
using Blog.Services.WebScraper.Infrastructure.EF.Context;
using Blog.Services.WebScraper.Infrastructure.EF.ScrapedArticles.Repositories;
using Blog.Services.WebScraper.Infrastructure.EF.ScrapedArticles.Services.Factories;
using Blog.Services.WebScraper.Infrastructure.EF.ScrapedArticles.Services.KeeperService;
using Microsoft.Extensions.DependencyInjection;
using  Blog.Services.Common.Infrastructure.Postgres;
namespace Blog.Services.WebScraper.Infrastructure;

public static class Extensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddPostgres<ScrapedArticleWriteDbContext>();
        services.AddScoped<IWebScraperService, KeeperService>();
        services.AddScoped<IScraperSeviceFactory, ScraperSeviceFactory>();
        services.AddScoped<IScrapedArticlesRepository, ScrapedArticlesRepository>();
        return services;
    }
}