// using System.Reflection;
// using Blog.Services.Common.Abstractions.Commands;
// using FluentValidation;
// using Microsoft.Extensions.DependencyInjection;
//
// namespace Blog.Services.Common.Infrastructure.Commands;
//
// internal static class Extensions
// {
//     public static IServiceCollection AddCommands(this IServiceCollection services, IEnumerable<Assembly> assemblies)
//     {
//         services.AddSingleton<ICommandDispatcher, CommandDispatcher>();
//         services.Scan(s => s.FromAssemblies(assemblies)
//             .AddClasses(c => c.AssignableTo(typeof(ICommandHandler<>))
//              )
//             .AsImplementedInterfaces()
//             .WithScopedLifetime());
//         
//         services.Scan(s => s.FromAssemblies(assemblies)
//             .AddClasses(c => c.AssignableTo(typeof(ICommandHandler<,>)))
//             .AsImplementedInterfaces()
//             .WithScopedLifetime());
//
//         services.Scan(s => s.FromAssemblies(assemblies)
//             .AddClasses(c => c.AssignableTo(typeof(IValidator<>)))
//             .AsSelfWithInterfaces()
//             .WithScopedLifetime());
//         
//         return services;
//     }
// }