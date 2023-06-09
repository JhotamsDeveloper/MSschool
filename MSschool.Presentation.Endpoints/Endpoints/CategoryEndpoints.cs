﻿using Carter;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.OpenApi.Models;
using MSschool.Application.Features.Categories.Commands.CreateCategory;
using MSschool.Application.Features.Categories.Commands.UpdateCategory;
using MSschool.Application.Features.Categories.Queries.GetActiveCategoryById;
using MSschool.Application.Features.Categories.Queries.PagGetAllCategories;
using MSschool.Application.Handlers;

namespace MSschool.Presentation.Endpoints.Endpoints;

public class CategoryEndpoints : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        var category = app.MapGroup("/category");

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


        category.MapPost("/Update", async (UpdateCategoryCommand command, ISender sender) =>
        {
            var result = await sender.Send(command);
            return Results.Ok(result);
        })
        .WithName("UpdateCategory")
        .WithOpenApi()
        .WithTags("Category");

        category.MapGet("/GetActivaById/{id:guid}", async (Guid id, ISender sender) =>
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
        category.MapGet("/AllActive", async (PagApiMinimalHelper query, ISender sender) =>
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
        })
        .WithName("AllActiveCategories")
        .WithOpenApi()
        .WithTags("Category");

        category.MapGet("/AllIncludingInactive", async (PagApiMinimalHelper query, ISender sender) =>
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
        })
        .WithName("AllCategoriesIncludingInactive")
        .WithOpenApi()
        .WithTags("Category");
    }
}
