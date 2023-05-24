using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MSschool.Infrastructure.EntityFramework.Persistence;

namespace MSschool.Infrastructure.EntityFramework
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfraestructureEntityFramework(
            this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<MsschoolContext>(options =>
                options.UseSqlServer(connectionString));
            return services;
        }
    }
}


