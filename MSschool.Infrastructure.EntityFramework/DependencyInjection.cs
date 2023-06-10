using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MSschool.Application.Contracts.Persistence;
using MSschool.Infrastructure.EntityFramework.Persistence;
using MSschool.Infrastructure.EntityFramework.Repositories;

namespace MSschool.Infrastructure.EntityFramework
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfraestructureEntityFramework(
            this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<MsschoolContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("ConnectionString"), 
                    sqlServerOptionsAction => 
                    {
                        sqlServerOptionsAction
                        .MigrationsAssembly("MSschool.Infrastructure.Migrations");
                    }));

            services.AddScoped<IUnitOfWork, UnitOfWorkService>();
            services.AddScoped(typeof(IAsyncRepository<>), typeof(RepositoryBaseService<>));

            return services;
        }
    }
}


