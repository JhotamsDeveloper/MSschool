﻿using System.Linq.Expressions;

namespace MSschool.Application.Domain.Specifications;

public class BaseSpecification<T> : ISpecification<T>
{
    public BaseSpecification(Expression<Func<T, bool>> criteria)
    {
        Criteria = criteria;
    }

    public Expression<Func<T, bool>> Criteria { get; }

    public List<Expression<Func<T, object>>> Includes { get; } = new List<Expression<Func<T, object>>>();

    public Expression<Func<T, object>> OrderBy { get; private set; } = default!;

    public Expression<Func<T, object>> OrderByDesc { get; private set; } = default!;

    public bool IgnoreQueryFilters { get; private set; }

    public int Take { get; private set; }

    public int Skip { get; private set; }

    public bool IsPagingEnable { get; private set; }


    protected void AddInclude(Expression<Func<T, object>> includeExpression)
    {
        Includes.Add(includeExpression);
    }

    protected void AddOrderBy(Expression<Func<T, object>> orderByExpression)
    {
        OrderBy = orderByExpression;
    }

    protected void AddOrderByDesc(Expression<Func<T, object>> orderByExpression)
    {
        OrderByDesc = orderByExpression;
    }

    protected void ApplyPaging(int skip, int take)
    {
        Skip = skip;
        Take = take;
        IsPagingEnable = true;
    }

    protected void AddIgnoreQueryFilters(bool filter)
    {
        IgnoreQueryFilters = filter;
    }

}