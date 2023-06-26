using Carter;
using Microsoft.OpenApi.Models;
using MSschool.Application;
using MSschool.Infrastructure.EntityFramework;
using MSschool.Presentation.Api.Middleware;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddInfraestructureEntityFramework(builder.Configuration)
    .AddAplication();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(config =>
{
    config.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "API University",
        Description = "Esta es una API funcional para universidades en donde puede crear un programa académico y su pensum, tiene el alcance de crear la planilla",
        Version = "v1",
        Contact= new OpenApiContact()
        {
            Name = "Jhonatan Alejandro Muñoz Serna",
            Email= "jhotams.dev@gmail.com",
            Url= new Uri("https://www.linkedin.com/in/jhotams/")
        }
    });
});

builder.Services.AddCarter();

builder.Services.AddHealthChecks()
    .AddSqlServer(builder
    .Configuration
    .GetConnectionString("ConnectionString")!);

builder.Host.UseSerilog((context, configuration) =>
    configuration.ReadFrom.Configuration(context.Configuration));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseSerilogRequestLogging();

app.UseMiddleware<ExceptionMiddleware>();
app.MapCarter();
app.UseHttpsRedirection();

app.MapHealthChecks("/health");

app.Run();
