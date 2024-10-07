
namespace Mst.DDD;
public interface IUnitOfWork : IDisposable
{
    bool IsDisposed { get; }

    Task<int> SaveAsync();
}
