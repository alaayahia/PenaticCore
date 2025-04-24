using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PenaticCore.Infrastructure.Data;
using PenaticCore.Infrastructure.Helpers;

namespace PenaticCore.Infrastructure.Utils
{
    public static class InfrastructureServiceCollectionExtensions
    {
        public static void AddInfrastructureServices(this IServiceCollection services, IConfiguration config)
        {
            string connectionString = config.GetConnectionString("DefaultConnection");
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(
                connectionString
            ),
             ServiceLifetime.Transient);
            services.AddTransient<MapperHelper>();
        }
    }
}
