using System.Reflection;
using Blog.Services.WebScraper.Application.ScrapedArticles.Services;
using Blog.Services.WebScraper.Application.ScrapedArticles.Services.Factories;

using Microsoft.Extensions.DependencyInjection;
namespace Blog.Services.WebScraper.Application;

public static class Extensions
{
    public static IServiceCollection AddApplication(this IServiceCollection services, Assembly[] moduleAssemblies)
    {

        services.AddMediatR(config =>
        {
            config.RegisterServicesFromAssemblies(moduleAssemblies);

        });
        return services;
    }
}