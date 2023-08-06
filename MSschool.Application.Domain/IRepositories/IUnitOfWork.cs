namespace MSschool.Application.Domain.IRepositories;

public interface IUnitOfWork : IDisposable
{
    IAsyncRepository<TEntity> Repository<TEntity>() where TEntity : class;
    ValueTask<int> SaveChangesAsync();
}
