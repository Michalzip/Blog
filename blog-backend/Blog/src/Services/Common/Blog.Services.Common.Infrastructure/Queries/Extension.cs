using System.Reflection;
using Blog.Services.Common.Abstractions.Queries;
using Microsoft.Extensions.DependencyInjection;

namespace Blog.Services.Common.Infrastructure.Queries;

public static class Extensions
{
    // public static IServiceCollection AddQueries(this IServiceCollection services, IEnumerable<Assembly> assemblies)
    // {
    //     services.AddSingleton<IQueryDispatcher, QueryDispatcher>();
    //     services.Scan(s => s.FromAssemblies(assemblies)
    //         .AddClasses(c => c.AssignableTo(typeof(IQueryHandler<,>)))
    //         .AsImplementedInterfaces()
    //         .WithScopedLifetime());
    //     return services;
    // }
}