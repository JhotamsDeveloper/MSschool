using Carter;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.OpenApi.Models;
using MSschool.Application.Features.Categories.Commands.CreateCategory;

namespace MSschool.Presentation.Endpoints.Endpoints.Category;

internal static class AddCategory
{
    internal static void Endpoint(RouteGroupBuilder category)
    {
        category.MapPost("/Add", AddCategory)
            .WithOpenApi(generatedOperation => new(generatedOperation)
            {
                OperationId = "AddCategory",
                Tags = new List<OpenApiTag>() { new OpenApiTag { Name = "Category" } },
                Summary = "Servicio encargado de crear todas las categorias",
                Description = "This is a description"
            })
            .Produces<CreateCategoryCommand>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status400BadRequest)
            .Accepts<CreateCategoryCommand>("application/json");

        static async Task<IResult> AddCategory(CreateCategoryCommand command, ISender sender)
        {
            var result = await sender.Send(command);
            return TypedResults.Ok(result);
        }
    }
}
