using Carter;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using MSschool.Application.Common;
using MSschool.Application.Features.Categories.Commands.CreateCategory;
using MSschool.Application.Features.Categories.Queries.GetCategoryById;
using MSschool.Application.Models.Category;

namespace MSschool.Presentation.Endpoints.Endpoints;

public class CategoryEndpoints : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapPost("/CreateCategory", async ([FromBody] CreateCommand command, ICommandDispatcher dispatcher) =>
        {
            var result = await dispatcher.Dispatch<CreateCommand, int>(command, new CancellationToken());
            return result;
        })
        .WithName("CreateCategory")
        .WithOpenApi();

        app.MapGet("/GetCategoryById", async (int id, IQueryDispatcher dispatcher) =>
        {
            var query = new GetCategoryByIdQuery() 
            { 
                Id= id 
            };
            var result = await dispatcher.Dispatch<GetCategoryByIdQuery, DtoCategory>(query, new CancellationToken());
            return result;

        })
        .WithName("GetCategoryById")
        .WithOpenApi();
    }
}
