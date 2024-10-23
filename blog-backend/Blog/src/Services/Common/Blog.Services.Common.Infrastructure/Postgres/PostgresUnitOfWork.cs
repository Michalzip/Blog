using Microsoft.EntityFrameworkCore;

namespace Blog.Services.Common.Infrastructure.Postgres; 

public abstract class PostgresUnitOfWork<T> : IUnitOfWork where T:DbContext
{
    private readonly T _writeDbContext;
    
        protected  PostgresUnitOfWork(T writeContext)
        {
            _writeDbContext = writeContext;
        }
        
    public async Task ExecuteAsync(Func<Task> action)
    {
        await using var transcation = await _writeDbContext.Database.BeginTransactionAsync();
        
        try
        {
            await action();
            await transcation.CommitAsync();
            
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            await transcation.RollbackAsync();
            await transcation.CommitAsync();
            throw;
        }
    }
}