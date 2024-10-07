namespace Mst.DomainDrivenDesign;

public interface IAggregateRoot : IEntity
{
    void ClearDomainEvents();

    IReadOnlyList<IDomainEvent> DomainEvents { get; }
}
