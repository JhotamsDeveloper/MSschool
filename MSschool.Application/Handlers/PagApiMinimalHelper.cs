using Microsoft.AspNetCore.Http;
using MSschool.Application.Constants.Pagination;
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

        string sort = context.Request.Query[PaginationHandlerKeys.sortkey]!;
        string search = context.Request.Query[PaginationHandlerKeys.searchkey]!;

        _ = int.TryParse(context.Request.Query[PaginationHandlerKeys.pageindexkey], out var pageIndex);
        pageIndex = pageIndex == 0 ? 1 : pageIndex;

        _ = int.TryParse(context.Request.Query[PaginationHandlerKeys.pagesizekey], out var pagesize);
        pagesize = pagesize == 0 ? 3 : pagesize;

        var result = new PagApiMinimalHelper(sort, search, pageIndex, pagesize);
        return ValueTask.FromResult<PagApiMinimalHelper?>(result);
    }
}
