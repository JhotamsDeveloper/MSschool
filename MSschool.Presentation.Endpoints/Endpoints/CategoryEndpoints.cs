using Carter;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using MSschool.Application.Features.Commands.CreateCategory;
using MSschool.Application.Features.Commands.UpdateCategory;

namespace MSschool.Presentation.Endpoints.Endpoints;

public class CategoryEndpoints : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapPost("/AddCategory", async (CreateCategoryCommand command, ISender sender) =>
        {
            var result = await sender.Send(command);
            return Results.Ok(result);
        })
        .WithName("AddCategory")
        .WithOpenApi();

        app.MapPost("/UpdateCategory", async (UpdateCategoryCommand command, ISender sender) =>
        {
            var result = await sender.Send(command);
            return Results.Ok(result);
        })
        .WithName("UpdateCategory")
        .WithOpenApi();
    }


}
