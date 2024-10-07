
namespace Mst.DDD;


public interface IQueryUnitOfWork : IDisposable
{
    bool IsDisposed { get; }
}
