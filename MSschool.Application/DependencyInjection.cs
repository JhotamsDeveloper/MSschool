using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using MSschool.Application.Behaviours;

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

            services.AddValidatorsFromAssembly(assemby);

            services.AddTransient(
                typeof(IPipelineBehavior<,>), 
                typeof(UnhandledExceptionBehaviour<,>));
            
            services.AddTransient(
                typeof(IPipelineBehavior<,>), 
                typeof(ValidationBehaviour<,>));
            
            return services;
        }
    }

}

