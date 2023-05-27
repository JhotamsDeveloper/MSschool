using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MSschool.Infrastructure.EntityFramework.Persistence;

namespace MSschool.Infrastructure.EntityFramework
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfraestructureEntityFramework(
            this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<MsschoolContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("ConnectionString")));

            return services;
        }
    }
}


