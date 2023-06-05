using Microsoft.Extensions.Logging;
using MSschool.Application.Contracts.Persistence;
using MSschool.Infrastructure.EntityFramework.Persistence;
using System.Collections;

namespace MSschool.Infrastructure.EntityFramework.Repositories;

internal sealed class UnitOfWorkService : IUnitOfWork
{
    private Hashtable? _repositories;

    public UnitOfWorkService(MsschoolContext context) => MsschoolContext = context;

    public MsschoolContext MsschoolContext { get; }

    public async ValueTask<int> SaveChangesAsync()
    {
        return await MsschoolContext.SaveChangesAsync();
    }

    public void Dispose()
    {
        MsschoolContext.Dispose();
    }

    public IAsyncRepository<TEntity> Repository<TEntity>() where TEntity : class
    {
        _repositories ??= new Hashtable();
        var type = typeof(TEntity).Name;

        if (!_repositories.ContainsKey(type))
        {
            Type reporitoryType = typeof(RepositoryBaseService<>);

            var repositoryInstance = Activator
                .CreateInstance(reporitoryType.MakeGenericType(typeof(TEntity)), MsschoolContext);

            _repositories.Add(type, repositoryInstance);
        }

        return (IAsyncRepository<TEntity>)_repositories[type]!;
    }
}
