
namespace Mst.DDD;

public interface IAggregateRoot : IEntity
{
    void ClearDomainEvents();

    IReadOnlyList<IDomainEvent> DomainEvents { get; }
}
