using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.OpenApi.Models;
using MSschool.Application.Features.ApplicationUsers.Command.AddUserAddresses;

namespace MSschool.Presentation.Endpoints.Endpoints.User;

internal static class AddUserPlaceOfBirth
{
    internal static void Endpoint(RouteGroupBuilder routeGroupBuilder)
    {
        routeGroupBuilder.MapPut("/AddUserPlaceOfBirth", AddUserPlaceOfBirth)
        .WithOpenApi(generatedOperation => new(generatedOperation)
        {
            OperationId = "AddUserPlaceOfBirth",
            Tags = new List<OpenApiTag>() { new OpenApiTag { Name = "User" } },
            Summary = "Servicio encargado de actualizar la dirección de nacimiento del usuario",
            Description = "This is a description"
        })
        .Produces<AddUserAddressesCommand>(StatusCodes.Status204NoContent)
        .Produces(StatusCodes.Status400BadRequest)
        .Accepts<AddUserAddressesCommand>("application/json");

        static async Task<IResult> AddUserPlaceOfBirth(AddUserAddressesCommand command, ISender sender)
        {
            await sender.Send(command);
            return TypedResults.NoContent();
        }
    }
}
