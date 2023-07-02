using Carter;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Primitives;
using MSschool.Application.Features.Categories.Commands.CreateCategory;
using MSschool.Application.Features.Categories.Commands.UpdateCategory;
using MSschool.Application.Features.Categories.Queries.GetActiveCategoryById;
using MSschool.Application.Features.Categories.Queries.GetAllCategories;
using MSschool.Application.Features.Categories.Queries.PagGetAllCategories;
using MSschool.Application.Handlers;
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

        //https://localhost:7033/AllActiveCategories?pageindex=1&&pagesize=10&&sort=nameAsc
        //https://localhost:7033/AllActiveCategories?pageindex=1&&pagesize=10&&sort=nameAsc&Search=ms
        app.MapGet("/AllActiveCategories", async (PagApiMinimalHelper query, ISender sender) =>
        {

            var categories = new PagGetAllCategoriesQuery()
            {
                PageIndex= query.PageIndex,
                PageSize = query.PageSize,
                Search = query.Search,
                Sort = query.Sort,
            };

            var result = await sender.Send(categories);
            return Results.Ok(result);
        })
        .WithName("AllActiveCategories")
        .Produces<PagApiMinimalHelper>(StatusCodes.Status200OK)
        .WithOpenApi()
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
