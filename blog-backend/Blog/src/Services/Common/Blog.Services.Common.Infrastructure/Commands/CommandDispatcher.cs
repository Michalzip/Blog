// using Blog.Services.Common.Abstractions.Commands;
// using Microsoft.Extensions.DependencyInjection;
// using FluentValidation;
// namespace Blog.Services.Common.Infrastructure.Commands;
//
// internal sealed class CommandDispatcher : ICommandDispatcher
// {
//     private readonly IServiceProvider _serviceProvider;
//
//     public CommandDispatcher(IServiceProvider serviceProvider)
//         => _serviceProvider = serviceProvider;
//
//     public async Task SendAsync<TCommand>(TCommand command, CancellationToken cancellationToken = default) where TCommand : class, ICommand
//     {
//         if (command is null)
//         {
//             return;
//         }
//
//         using var scope = _serviceProvider.CreateScope();
//         var handler = scope.ServiceProvider.GetRequiredService<ICommandHandler<TCommand>>();
//
//         var validator = scope.ServiceProvider.GetValidator<TCommand>();
//         if (validator is not null)
//         { 
//             await validator.ValidateAndThrowAsync(command, cancellationToken: cancellationToken);
//         }
//         await handler.HandleAsync(command, cancellationToken);
//     }
//
//     public async Task<TResult> SendAsync<TCommand, TResult>(TCommand command, CancellationToken cancellationToken = default) where TCommand : class, ICommand<TResult> where TResult : class
//     {
//         if (command is null)
//         {
//             throw new InvalidOperationException("Command not found");
//         }
//
//         using var scope = _serviceProvider.CreateScope();
//         var handler = scope.ServiceProvider.GetRequiredService<ICommandHandler<TCommand, TResult>>();
//         
//         var validator = scope.ServiceProvider.GetValidator<TCommand>();
//         if (validator is not null)
//         { 
//             await validator.ValidateAndThrowAsync(command, cancellationToken: cancellationToken);
//         }
//         return await handler.HandleAsync(command, cancellationToken);
//     }
//     
// }
//
// public static class IServiceProviderExtensions
// {
//     public static IValidator<T> GetValidator<T>(this IServiceProvider serviceProvider)
//     {
//         return serviceProvider.GetService<IValidator<T>>();
//     } 
// }