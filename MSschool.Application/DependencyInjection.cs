using Microsoft.Extensions.DependencyInjection;

namespace MSschool.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAplication(
            this IServiceCollection services)
        {
            var assemby = typeof(DependencyInjection).Assembly;

            services.AddMediatR(configuration =>
                configuration.RegisterServicesFromAssembly(assemby));

            return services;
        }
    }

}

