using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.OpenApi.Models;
using MSschool.Application.Features.Categories.Commands.DeleteCategory;

namespace MSschool.Presentation.Endpoints.Endpoints.Category;

internal static class DeleteCategory
{
    internal static void Endpoint(RouteGroupBuilder category)
    {
        category.MapDelete("Delete/{id}", DeleteCategory)
            .WithOpenApi(generatedOperation => new(generatedOperation)
            {
                OperationId = "Delete",
                Tags = new List<OpenApiTag>() { new OpenApiTag { Name ="Category"} },
                Summary = "Servicio para eliminar una categoria",
                Description = "This is description"
            });

        static async Task<IResult> DeleteCategory(Guid id, ISender sender)
        {
            var result = await sender.Send(new DeleteCategoryCommand(id));
            return Results.Ok(result);
        }
    }
}
