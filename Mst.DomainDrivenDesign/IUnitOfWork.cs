namespace Mst.DomainDrivenDesign;
public interface IUnitOfWork : IDisposable
{
    bool IsDisposed { get; }

    Task<int> SaveAsync();
}
