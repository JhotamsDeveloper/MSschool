using Carter;
using MSschool.Application;
using MSschool.Infrastructure.EntityFramework;
using MSschool.Presentation.Api.Middleware;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddInfraestructureEntityFramework(builder.Configuration)
    .AddAplication();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCarter();


builder.Services.AddHealthChecks()
    .AddSqlServer(builder
    .Configuration
    .GetConnectionString("ConnectionString")!);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseMiddleware<ExceptionMiddleware>();
app.MapCarter();
app.UseHttpsRedirection();

app.MapHealthChecks("/health");

app.Run();
