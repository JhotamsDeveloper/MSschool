using Carter;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.OpenApi.Models;
using MSschool.Application.Features.ApplicationUsers.Command.CreateUser;

namespace MSschool.Presentation.Endpoints.Endpoints.User;

internal static class AddUser
{
    internal static void Endpoint(RouteGroupBuilder routeGroupBuilder)
    {
        routeGroupBuilder.MapPost("/Add", AddUser)
        .WithOpenApi(generatedOperation => new(generatedOperation)
        {
            OperationId = "AddUser",
            Tags = new List<OpenApiTag>() { new OpenApiTag { Name = "User" } },
            Summary = "Servicio encargado de crear los usuarios",
            Description = "This is a description"
        })
        .Produces<CreateUserCommand>(StatusCodes.Status200OK)
        .Produces(StatusCodes.Status400BadRequest)
        .Accepts<CreateUserCommand>("application/json");

        static async Task<IResult> AddUser(CreateUserCommand command, ISender sender)
        {
            var result = await sender.Send(command);
            return TypedResults.Ok(result);
        }
    }
}
