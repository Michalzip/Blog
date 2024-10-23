namespace Blog.Services.Common.Infrastructure.Postgres;

public class UnitOfWorkTypeRegistry
{
   private readonly Dictionary<string, Type> _types = new();
   //register service that use unit of work
   //example key: WebScraper value: ScrapeArticlesUnitOfWork
   public void Register<T>() where T : IUnitOfWork => _types[GetKey<T>()] = typeof(T);
   //get service
   public Type Resolve<T>() => _types.TryGetValue(GetKey<T>(), out var type) ? type : null; 
   private static string GetKey<T>() => $"{typeof(T).GetServiceName()}"; 
}