using Microsoft.Extensions.DependencyInjection;
using MSschool.Application.Common;

namespace MSschool.Application.Dispatchers;

public class QueryDispatcher : IQueryDispatcher
{
    private readonly IServiceProvider _serviceProvider;

    public QueryDispatcher(IServiceProvider serviceProvider) =>
        _serviceProvider = serviceProvider;

    public Task<TQueryResult> Dispatch<TQuery, TQueryResult>(
        TQuery query, 
        CancellationToken cancellation)
    {
        var handler = _serviceProvider
            .GetRequiredService<IQueryHandler<TQuery, TQueryResult>>();
        return handler
            .Handle(query, cancellation);
    }
}
