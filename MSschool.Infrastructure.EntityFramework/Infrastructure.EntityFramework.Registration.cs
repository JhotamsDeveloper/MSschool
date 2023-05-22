using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MSschool.Infrastructure.EntityFramework.Persistence;

namespace MSschool.Infrastructure.EntityFramework;

public static class Infrastructure
{
    public static IServiceCollection AddInfrastructureEntityFrameworkServices(this IServiceCollection services, IConfiguration configuration)
    {
        //Server=JHOTAMS;Database=MSSchoolS1;Integrated Security = true;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
        services.AddDbContext<MsschoolContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("ConnectionString")));
        return services;
    }
}
