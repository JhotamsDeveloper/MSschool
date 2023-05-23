using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MSschool.Application;

public static class ApplicationServiceRegistration
{
    public static IServiceCollection AddApplicationServices(
        this IServiceCollection services, 
        IConfiguration configuration)
    {
        return services;
    }
}
