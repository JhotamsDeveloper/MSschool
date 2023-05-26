using Carter;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace MSschool.Presentation.Endpoints.Endpoints;

public class CategoryEndpoints : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/weatherforecast", () =>
        {
            return Results.Ok("Hola Mundo");
        })
        .WithName("GetWeatherForecast")
        .WithOpenApi();
    }
}
