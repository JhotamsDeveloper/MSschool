using MSschool.Application.Exceptions;
using MSschool.Presentation.Api.Error;
using Newtonsoft.Json;
using System.Net;

namespace MSschool.Presentation.Api.Middleware;

public class ExceptionMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<ExceptionMiddleware> _logger;
    private readonly IHostEnvironment _environment;

    public ExceptionMiddleware(
        RequestDelegate next, 
        ILogger<ExceptionMiddleware> logger, IHostEnvironment environment)
    {
        _next = next;
        _logger = logger;
        _environment = environment;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, ex.Message);
            context.Response.ContentType = "application/json";
            var statusCode = (int)HttpStatusCode.InternalServerError;
            var result = string.Empty;

            switch (ex)
            {
                case NotFoundEx _:
                    statusCode = (int)HttpStatusCode.NotFound;
                    break;

                case ValidationEx validationException:
                    statusCode = (int)HttpStatusCode.BadRequest;
                    result = JsonConvert.SerializeObject(
                        new CodeErrorException(
                            statusCode,
                            ex.Message,
                            validationException.Errors));
                    break;

                case BadRequestEx _:
                    statusCode = (int)HttpStatusCode.BadRequest;
                    break;

                case ErrorInternalEx _:
                    statusCode = (int)HttpStatusCode.InternalServerError;
                    break;

                default:
                    break;
            }

            if (string.IsNullOrEmpty(result))
            {
                if (_environment.IsDevelopment())
                {
                    result = JsonConvert.SerializeObject(
                        new CodeErrorException(
                            statusCode,
                            ex.Message,
                            ex.StackTrace));
                }
                else
                {
                    result = JsonConvert.SerializeObject(
                        new CodeErrorException(
                            statusCode,
                            ex.Message));
                }
            }

            context.Response.StatusCode = statusCode;
            await context.Response.WriteAsync(result);
        }
    }


}
