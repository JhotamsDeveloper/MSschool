using Microsoft.EntityFrameworkCore;
using MSschool.Application.Domain.Common;
using MSschool.Application.Domain.Specifications;

namespace MSschool.Infrastructure.EntityFramework.Specification;

public sealed class SpecificationEvaluator<T> where T : Audit
{
    public static IQueryable<T> GetQuery(
        IQueryable<T> inputQuery, 
        ISpecification<T> spec)
    {
        if (spec.OrderBy != null)
        {
            inputQuery = inputQuery.OrderBy(spec.OrderBy);
        }

        if (spec.OrderByDesc != null)
        {
            inputQuery = inputQuery.OrderBy(spec.OrderByDesc);
        }

        if (spec.IgnoreQueryFilters)
        {
            inputQuery = inputQuery.IgnoreQueryFilters();
        }

        if (spec.Criteria != null)
        {
            inputQuery = inputQuery.Where(spec.Criteria);
        }

        if (spec.IsPagingEnable)
        {
            inputQuery = inputQuery.Skip(spec.Skip).Take(spec.Take);
        }

        inputQuery = spec.Includes.Aggregate(inputQuery, (current, include) => current.Include(include));

        return inputQuery;
    }
}
