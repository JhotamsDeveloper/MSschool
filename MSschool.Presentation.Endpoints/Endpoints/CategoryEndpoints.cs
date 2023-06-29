using Carter;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Primitives;
using MSschool.Application.Features.Categories.Commands.CreateCategory;
using MSschool.Application.Features.Categories.Commands.UpdateCategory;
using MSschool.Application.Features.Categories.Queries.GetActiveCategoryById;
using MSschool.Application.Features.Categories.Queries.GetAllCategories;
using MSschool.Application.Features.Categories.Queries.PagGetAllCategories;
using System;
using System.Net;

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
        .WithTags("Category");

        app.MapPost("/UpdateCategory", async (UpdateCategoryCommand command, ISender sender) =>
        {
            var result = await sender.Send(command);
            return Results.Ok(result);
        })
        .WithName("UpdateCategory")
        .WithOpenApi()
        .WithTags("Category");

        app.MapGet("/GetCategoryActivaById/{id:guid}", async (Guid id, ISender sender) =>
        {
            var category = new GetActiveCategoryByIdQuery(id);
            var result = await sender.Send(category);
            return Results.Ok(result);
        })
        .WithName("GetCategoryActivaById")
        .WithOpenApi()
        .WithTags("Category");

        app.MapGet("/AllActiveCategories", async (HttpRequest request, ISender sender) =>
        {
            StringValues test = request.Query["PageIndex"];
            var person = await request.ReadFromJsonAsync<PagGetAllCategoriesQuery>();
            var categories = new PagGetAllCategoriesQuery() 
            { 
                PageIndex = 2,
                PageSize= 2,
                Search = string.Empty,
                Sort = string.Empty,
            };

            var result = await sender.Send(categories);
            return Results.Ok(result);
        })
        .WithName("AllActiveCategories")
        .WithOpenApi()
        .Produces((int)HttpStatusCode.OK, typeof(PagGetAllCategoriesQuery))
        .WithTags("Category");

        app.MapGet("/AllCategoriesIncludingInactive", async (ISender sender) =>
        {
            var categories = new GetAllCategoriesQuery(true);
            var result = await sender.Send(categories);
            return Results.Ok(result);
        })
        .WithName("AllCategoriesIncludingInactive")
        .WithOpenApi()
        .WithTags("Category");
    }


}
