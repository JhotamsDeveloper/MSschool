using Carter;
using MSschool.Application;
using MSschool.Infrastructure.EntityFramework;


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

app.MapCarter();
app.UseHttpsRedirection();

app.MapHealthChecks("/health");

app.Run();
