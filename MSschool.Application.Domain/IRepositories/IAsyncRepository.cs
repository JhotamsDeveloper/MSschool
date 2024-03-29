﻿using MSschool.Application.Domain.Shared.Specifications;
using System.Linq.Expressions;

namespace MSschool.Application.Domain.IRepositories;

public interface IAsyncRepository<T> where T : class
{
    Task<IReadOnlyList<T>> GetAllAsync();
    Task<IReadOnlyList<T>> GetAllIgnoreQueryFiltersAsync();
    Task<IReadOnlyList<T>> GetAsync(
        Expression<Func<T, bool>>? predicate);
    Task<IReadOnlyList<T>> GetAsync(
        Expression<Func<T, bool>>? predicate = null,
        Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
        string? includeString = null, bool? disableTracking = true);
    Task<IReadOnlyList<T>> GetAsync(
        Expression<Func<T, bool>>? predicate = null,
        Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
        List<Expression<Func<T, object>>>? includes = null,
        bool? disableTracking = true);
    Task<int> CountAsync(ISpecification<T> spec);
    Task<T> GetIdWithSpec(ISpecification<T> spec);
    Task<IReadOnlyList<T?>> GetAllWithSpec(ISpecification<T> spec);
    Task<bool> Exitst(Expression<Func<T, bool>> predicate);
    Task<T> GetByIdAsync(Guid id);
    Task AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(T entity);
    void Add(T entity);
    void Update(T entity);
    void Delete(T entity);

}
