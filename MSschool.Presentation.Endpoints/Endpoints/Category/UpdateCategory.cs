using Carter;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.OpenApi.Models;
using MSschool.Application.Features.Categories.Commands.UpdateCategory;

namespace MSschool.Presentation.Endpoints.Endpoints.Category;

internal static class UpdateCategory
{
    internal static void Endpoint(RouteGroupBuilder category)
    {
        category.MapPut("/Update", UpdateCategory)
            .WithOpenApi(generatedOperation => new(generatedOperation)
            {
                OperationId = "Update",
                Tags = new List<OpenApiTag>() { new OpenApiTag { Name = "Category" } },
                Summary = "Servicio encargado de actualizar las categorias",
                Description = "This is a description"
            })
            .Produces<UpdateCategoryCommand>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status400BadRequest)
            .Accepts<UpdateCategoryCommand>("application/json");

        static async Task<IResult> UpdateCategory(UpdateCategoryCommand command, ISender sender)
        {
            var result = await sender.Send(command);
            return Results.Ok(result);
        }
    }
}
