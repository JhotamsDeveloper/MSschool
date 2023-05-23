namespace MSschool.Application.Contracts.Persistence;

public interface IUnitOfWork : IDisposable
{
    IAsyncRepository<TEntity> Repository<TEntity>() where TEntity : class;
    Task<int> Complete();
}
