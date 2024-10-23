using Blog.Services.Common.Abstractions.Response;
using MediatR;

namespace Blog.Services.Common.Abstractions.Queries;

public interface IQueryHandler<in TQuery, TResponse> : IRequestHandler<TQuery, Result<TResponse>>
    where TQuery : IQuery<TResponse>;

