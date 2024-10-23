using Blog.Services.Common.Abstractions.Commands;
using Blog.Services.Common.Abstractions.Queries;

namespace Blog.Services.Common.Abstractions.Dispatcher;

public interface IDispatcher
{
    Task SendAsync<T>(T command, CancellationToken cancellationToken = default) where T : class, ICommand;
    Task<TResult> SendAsync<T,TResult>(T command, CancellationToken cancellationToken = default) where T : class , ICommand<TResult> where TResult : class;
    Task<TResult> QueryAsync<TResult>(IQuery<TResult> query, CancellationToken cancellationToken = default);
}