using Blog.Services.Common.Abstractions.Response;
using MediatR;

namespace Blog.Services.Common.Abstractions.Queries;

public interface IQuery<TResponse> : IRequest<Result<TResponse>>;