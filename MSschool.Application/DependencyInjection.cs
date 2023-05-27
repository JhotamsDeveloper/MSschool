using Microsoft.Extensions.DependencyInjection;
using MSschool.Application.Common;
using MSschool.Application.Dispatchers;

namespace MSschool.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAplication(
            this IServiceCollection services)
        {
            services.AddSingleton<ICommandDispatcher, CommandDispatcher>();
            services.AddSingleton<IQueryDispatcher, QueryDispatcher>();

            foreach (var type in GetAssembliesIQueryHandler())
            {
                foreach (var interfaceType in type.GetInterfaces()
                    .Where(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IQueryHandler<,>)))
                {
                    services.AddSingleton(interfaceType, type);
                }
            }

            foreach (var type in GetAssembliesICommandHandler())
            {
                foreach (var interfaceType in type.GetInterfaces()
                    .Where(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(ICommandHandler<,>)))
                {
                    services.AddSingleton(interfaceType, type);
                }
            }

            return services;
        }

private static IEnumerable<Type> GetAssembliesICommandHandler()
{
    return AppDomain.CurrentDomain.GetAssemblies()
                    .SelectMany(s => s.GetTypes())
                    .Where(p => p.IsClass && !p.IsAbstract && p.GetInterfaces().Any(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(ICommandHandler<,>)));
}

private static IEnumerable<Type> GetAssembliesIQueryHandler()
{
    return AppDomain.CurrentDomain
                    .GetAssemblies()
                    .SelectMany(s => s.GetTypes())
                    .Where(p => p.IsClass && !p.IsAbstract && p.GetInterfaces().Any(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IQueryHandler<,>)));
}
    }

}

