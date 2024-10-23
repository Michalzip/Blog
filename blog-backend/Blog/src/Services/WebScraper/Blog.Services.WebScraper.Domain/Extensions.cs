using Microsoft.Extensions.DependencyInjection;

namespace Blog.Services.WebScraper.Domain
{
    public static class Extensions
    {
        public static IServiceCollection AddDomain(this IServiceCollection services)
        {
            return services;
        }
    }
}
