using Carter;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using MSschool.Application.Features.Categories.Commands.CreateCategory;
using MSschool.Application.Features.Categories.Commands.UpdateCategory;
using MSschool.Application.Features.Categories.Queries.GetActiveCategory;
using MSschool.Application.Features.Categories.Queries.GetAllCategories;

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

        app.MapGet("/ActiveCategory/{id:guid}", async (Guid id, ISender sender) =>
        {
            var category = new GetActiveCategoryQuery(id);
            var result = await sender.Send(category);
            return Results.Ok(result);
        })
        .WithName("ActiveCategory")
        .WithOpenApi();

        app.MapGet("/AllActiveCategories", async (ISender sender) =>
        {
            var categories = new GetAllCategoriesQuery(false);
            var result = await sender.Send(categories);
            return Results.Ok(result);
        })
        .WithName("AllActiveCategories")
        .WithOpenApi();

        app.MapGet("/AllCategoriesIncludingInactive", async (ISender sender) =>
        {
            var categories = new GetAllCategoriesQuery(true);
            var result = await sender.Send(categories);
            return Results.Ok(result);
        })
        .WithName("AllCategoriesIncludingInactive")
        .WithOpenApi();
    }


}
