namespace Mst.DomainDrivenDesign;


public interface IQueryUnitOfWork : IDisposable
{
    bool IsDisposed { get; }
}
