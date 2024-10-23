using Blog.Services.Common.Abstractions.Time;
using Blog.Services.Common.Infrastructure.Time;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace Blog.Services.Common.Infrastructure;

public  static class Extensions
{

    public static IServiceCollection AddAbstractionInfrastructure(
        this IServiceCollection services

    )
    {
        // services.AddCommands(assemblies);
        // services.AddQueries(assemblies);
        services.AddSingleton<IClock, UtcClock>();
        // services.AddSingleton<IDispatcher, InMemoryDispatcher>();
        
        return services;
    }
    
    
    public static T GetOptions<T>(this IServiceCollection services, string sectionName) where T : new()
    { 
        var serviceProvider = services.BuildServiceProvider();
        var configuration = serviceProvider.GetRequiredService<IConfiguration>();
        return configuration.GetOptions<T>(sectionName);
    }
    public static T GetOptions<T>(this IConfiguration configuration, string sectionName)
        where T : new()
    {
        var options = new T();
        configuration.GetSection(sectionName).Bind(options);
        return options;
    }

    public static string GetServiceName(this Type type)
    {
        if (type?.Namespace == null)
        {
            return string.Empty;
            
        }

        return type.Namespace.StartsWith("Blog.Services.") ? type.Namespace.Split(".")[2].ToLowerInvariant()
            : string.Empty;;
    }
}