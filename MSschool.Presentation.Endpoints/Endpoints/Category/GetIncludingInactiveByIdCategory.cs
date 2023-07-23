using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.OpenApi.Models;
using MSschool.Application.Features.Categories.Queries.GetCategoryById;
using MSschool.Application.Features.Categories.Queries.PagGetAllCategories;

namespace MSschool.Presentation.Endpoints.Endpoints.Category;

internal class GetIncludingInactiveByIdCategory
{
    internal static void Endpoind(RouteGroupBuilder category)
    {
        category.MapGet("GetByIdCategoryIncludingInactive/{id}", GetActiveCategoryById)
            .WithOpenApi(generatedOperation => new(generatedOperation)
            {
                OperationId = "GetByIdCategoryIncludingInactive",
                Tags = new List<OpenApiTag>() { new OpenApiTag { Name = "Category" } },
                Summary = "Servicio encargado de obtener solo las categorias activas",
                Description = "This is a description"
            })
            .Produces<PagGetAllCategoriesResponse>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status400BadRequest);

        static async Task<IResult> GetActiveCategoryById(Guid id, ISender sender)
        {
            var query = new GetCategoryByIdQuery(id, true);
            var result = await sender.Send(query);
            return Results.Ok(result);
        }
    }
}
