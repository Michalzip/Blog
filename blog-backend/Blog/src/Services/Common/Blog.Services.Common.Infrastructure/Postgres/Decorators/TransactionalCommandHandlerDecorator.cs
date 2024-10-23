using Blog.Services.Common.Abstractions.Commands;
using Blog.Services.Common.Abstractions.Response;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Blog.Services.Common.Infrastructure.Postgres.Decorators;

public class TransactionalCommandHandlerDecorator<T> : ICommandHandler<T> where T : class, ICommand
{
    private readonly ICommandHandler<T> _handler;
    private readonly UnitOfWorkTypeRegistry _unitOfWorkTypeRegistry;
    private readonly IServiceProvider _serviceProvider;
    private readonly ILogger<TransactionalCommandHandlerDecorator<T>> _logger;

    public TransactionalCommandHandlerDecorator(ICommandHandler<T> handler, UnitOfWorkTypeRegistry unitOfWorkTypeRegistry,
        IServiceProvider serviceProvider, ILogger<TransactionalCommandHandlerDecorator<T>> logger)
    {
        _handler = handler;
        _unitOfWorkTypeRegistry = unitOfWorkTypeRegistry;
        _serviceProvider = serviceProvider;
        _logger = logger;
    }
  

    public async Task<Result> Handle(T request, CancellationToken cancellationToken)
    
    {
        var unitOfWorkType = _unitOfWorkTypeRegistry.Resolve<T>();
        
        if (unitOfWorkType is null)
        {
            await _handler.Handle(request, cancellationToken);
            return null;
        }
        
        var unitOfWork = (IUnitOfWork)_serviceProvider.GetRequiredService(unitOfWorkType);
        var unitOfWorkName = unitOfWorkType.Name;
        var name = request.GetType().Name;
        _logger.LogInformation("Handling: {Name} using TX ({UnitOfWorkName})...", name, unitOfWorkName);
        await unitOfWork.ExecuteAsync(() => _handler.Handle(request, cancellationToken));
        _logger.LogInformation("Handled: {Name} using TX ({UnitOfWorkName})", name, unitOfWorkName);
        throw new NotImplementedException();
    }
}