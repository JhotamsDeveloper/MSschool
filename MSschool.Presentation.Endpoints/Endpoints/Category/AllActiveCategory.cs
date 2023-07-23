using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.OpenApi.Models;
using MSschool.Application.Features.Categories.Queries.PagGetAllCategories;
using MSschool.Application.Handlers;

namespace MSschool.Presentation.Endpoints.Endpoints.Category;

internal static class AllActiveCategory
{
    internal static void Endpoint(RouteGroupBuilder category)
    {
        //https://localhost:7033/AllActiveCategories?pageindex=1&&pagesize=10&&sort=nameAsc
        //https://localhost:7033/AllActiveCategories?pageindex=1&&pagesize=10&&sort=nameAsc&Search=ms

        category.MapGet("AllActive", AllActive)
            .WithOpenApi(generatedOperation => new(generatedOperation)
            {
                OperationId = "AllActive",
                Tags = new List<OpenApiTag>() { new OpenApiTag { Name = "Category" } },
                Summary = "Servicio encargado de obtener todas las categorias activas",
                Description = "This is a description"
            })
            .Produces<PagGetAllCategoriesResponse>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status400BadRequest);

        static async Task<IResult> AllActive(PagApiMinimalHelper query, ISender sender)
        {
            var categories = new PagGetAllCategoriesQuery()
            {
                PageIndex = query.PageIndex,
                PageSize = query.PageSize,
                Search = query.Search,
                Sort = query.Sort,
                DisableGlobalFilters = false
            };

            var result = await sender.Send(categories);
            return Results.Ok(result);
        }
    }
}
