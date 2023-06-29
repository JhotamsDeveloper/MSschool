using Microsoft.EntityFrameworkCore;
using MSschool.Application.Contracts.Persistence;
using MSschool.Application.Domain.Common;
using MSschool.Application.Domain.Specifications;
using MSschool.Infrastructure.EntityFramework.Persistence;
using MSschool.Infrastructure.EntityFramework.Specification;
using System.Linq.Expressions;

namespace MSschool.Infrastructure.EntityFramework.Repositories;

internal sealed class RepositoryBaseService<T> : IAsyncRepository<T> where T : Audit
{
    private readonly MsschoolContext _context;

    public RepositoryBaseService(MsschoolContext context) => _context = context;

    public void Add(T entity) 
    { 
        _context
            .Set<T>()
            .Add(entity);
    }

    public async Task AddAsync(T entity) 
    {
        await _context
            .Set<T>()
            .AddAsync(entity);
    }

    public async Task<int> CountAsync(ISpecification<T> spec)
    {
        return await ApplySpecification(spec).CountAsync();
    }

    public void Delete(T entity)
    {
        _context
            .Set<T>()
            .Remove(entity);
    }

    public async Task DeleteAsync(T entity)
    {
        _context
            .Set<T>()
            .Remove(entity);
        
        await Task.CompletedTask;
    }

    public async Task<bool> Exitst(Expression<Func<T, bool>> predicate)
    {
        var result = await _context.Set<T>()
            .AnyAsync(predicate);

        return result;
    }

    public async Task<IReadOnlyList<T>> GetAllAsync()
    {
        return await _context.Set<T>()
            .ToListAsync();
    }

    public async Task<IReadOnlyList<T>> GetAllIgnoreQueryFiltersAsync() 
    {
        return await _context.Set<T>()
            .IgnoreQueryFilters()
            .ToListAsync();
    }

    public async Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>>? predicate)
    {
        return await _context
            .Set<T>()
            .Where(predicate!)
            .ToListAsync();
    }

    public async Task<IReadOnlyList<T>> GetAsync(
        Expression<Func<T, bool>>? predicate = null, 
        Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null, 
        string? includeString = null, 
        bool? disableTracking = true)
    {
        IQueryable<T> query = _context.Set<T>();

        if ((bool)disableTracking!)
            query = query.AsNoTracking();

        if (!string.IsNullOrWhiteSpace(includeString))
            query = query.Include(includeString);

        if (predicate != null)
            query = query.Where(predicate);

        if (orderBy != null)
            return await orderBy(query).ToListAsync();

        return await query.ToListAsync();
    }

    public async Task<IReadOnlyList<T>> GetAsync(
        Expression<Func<T, bool>>? predicate = null, 
        Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null, 
        List<Expression<Func<T, object>>>? includes = null, 
        bool? disableTracking = true)
    {
        IQueryable<T> query = _context.Set<T>();

        if ((bool)disableTracking!)
            query = query.AsNoTracking();

        if (includes != null)
            query = includes.Aggregate(query, (current, include) => current.Include(include));

        if (predicate != null)
            query = query.Where(predicate);

        if (orderBy != null)
            return await orderBy(query).ToListAsync();

        return await query.ToListAsync();
    }

    public async Task<T> GetByIdAsync(Guid id)
    {
        var result = await _context
            .Set<T>()
            .AsNoTracking()
            .FirstOrDefaultAsync(
            firsth => firsth.Id!.Equals(new Id(id)));

        return result!;
    }

    public async Task<T> GetIdWithSpec(ISpecification<T> spec)
    {
        var result = await ApplySpecification(spec).FirstOrDefaultAsync();
        return result!;
    }

    public async Task<IReadOnlyList<T>> GetAllWithSpec(ISpecification<T> spec)
    {
        return await ApplySpecification(spec).ToListAsync();
    }

    public void Update(T entity)
    {
        _context.Set<T>()
            .Attach(entity);

        _context.Entry(entity)
            .State = EntityState.Modified;
    }

    public async Task UpdateAsync(T entity)
    {
        _context.Set<T>().Attach(entity);
        _context.Entry(entity).State = EntityState.Modified;
        await Task.CompletedTask;
    }

    private IQueryable<T> ApplySpecification(ISpecification<T> spec)
    {
        return SpecificationEvaluator<T>.GetQuery(_context.Set<T>().AsQueryable(), spec);
    }
}
