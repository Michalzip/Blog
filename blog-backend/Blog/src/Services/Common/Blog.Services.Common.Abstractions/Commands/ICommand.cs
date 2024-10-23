using Blog.Services.Common.Abstractions.Response;
using MediatR;

namespace Blog.Services.Common.Abstractions.Commands;


public interface ICommand : IRequest<Result>, IBaseCommand;

public interface ICommand<TResponse> : IRequest<Result<TResponse>>, IBaseCommand;

public interface IBaseCommand;
