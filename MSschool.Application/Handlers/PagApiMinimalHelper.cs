using Microsoft.AspNetCore.Http;
using System.Reflection;

namespace MSschool.Application.Handlers;

public record class PagApiMinimalHelper(string Sort, string Search, int PageIndex, int PageSize)
{
    public static ValueTask<PagApiMinimalHelper?> BindAsync(HttpContext context, ParameterInfo parameter)
    {
        if (parameter is null)
        {
            throw new ArgumentNullException(nameof(parameter));
        }

        const string sortkey = "sort";
        const string searchkey = "search";
        const string pageindexkey = "pageIndex";
        const string pagesizekey = "pagesize";

        Enum.TryParse<SortDirection>(context.Request.Query[sortkey],
                             ignoreCase: true, out var _);

        _ = int.TryParse(context.Request.Query[pageindexkey], out var pageIndex);
        pageIndex = pageIndex == 0 ? 1 : pageIndex;

        _ = int.TryParse(context.Request.Query[pagesizekey], out var pagesize);
        pagesize = pagesize == 0 ? 3 : pagesize;

        var result = new PagApiMinimalHelper(
            context.Request.Query[sortkey].ToString(),
            context.Request.Query[searchkey].ToString(),
            pageIndex,
            pagesize);

        return ValueTask.FromResult<PagApiMinimalHelper?>(result);
    }
}

public enum SortDirection
{
    Default,
    Asc,
    Desc
}
