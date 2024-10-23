
namespace Blog.Services.Common.Abstractions.Kernel
{
    public class Entity
    {
        public Guid  Id { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        private List<IDomainEvent> _domainEvents;
        public IReadOnlyCollection<IDomainEvent> DomainEvents => _domainEvents?.AsReadOnly();
        
        public void ClearDomainEvents()
        {
            _domainEvents?.Clear();
        }

        protected void AddDomainEvebt(IDomainEvent domainEvent)
        {
            _domainEvents ??= [];
            this._domainEvents.Add((domainEvent));
        }
    }
}