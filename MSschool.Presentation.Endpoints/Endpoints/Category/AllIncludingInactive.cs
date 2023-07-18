using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.OpenApi.Models;
using MSschool.Application.Features.Categories.Queries.PagGetAllCategories;
using MSschool.Application.Handlers;

namespace MSschool.Presentation.Endpoints.Endpoints.Category;

internal static class AllIncludingInactive
{
    internal static void Endpoint(RouteGroupBuilder category)
    {
        category.MapGet("AllIncludingInactive", AllIncludingInactive)
            .WithOpenApi(generatedOperation => new(generatedOperation)
            {
                OperationId = "AllIncludingInactive",
                Tags = new List<OpenApiTag>() { new OpenApiTag { Name = "Category" } },
                Summary = "Servicio encargado de obtener todas las categorias incluyendo las inactivas",
                Description = "This is a description"
            })
            .Produces<PagGetAllCategoriesResponse>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status400BadRequest);

        static async Task<IResult> AllIncludingInactive(PagApiMinimalHelper query, ISender sender)
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
        }
    }
}
