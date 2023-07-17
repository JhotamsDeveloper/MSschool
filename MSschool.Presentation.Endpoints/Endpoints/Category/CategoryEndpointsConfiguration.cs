using Carter;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using MSschool.Application.Features.Categories.Queries.PagGetAllCategories;
using MSschool.Application.Handlers;

namespace MSschool.Presentation.Endpoints.Endpoints.Category;

public class CategoryEndpointsConfiguration : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        var category = app.MapGroup("/category");

        AddCategory.Endpoint(category);
        UpdateCategory.Endpoint(category);
        AllActive.Endpoint(category);

        category.MapGet("/AllIncludingInactive", async (PagApiMinimalHelper query, ISender sender) =>
        {
            var categories = new PagGetAllCategoriesQuery()
            {
                PageIndex = query.PageIndex,
                PageSize = query.PageSize,
                Search = query.Search,
                Sort = query.Sort,
                DisableGlobalFilters = true
            };

            var result = await sender.Send(categories);
            return Results.Ok(result);
        })
        .WithName("AllCategoriesIncludingInactive")
        .WithOpenApi()
        .WithTags("Category");


    }
}
