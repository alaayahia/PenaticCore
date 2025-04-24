using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PenaticCore.Application.Common;
using PenaticCore.Application.Modules.Helpers;
using PenaticCore.Application.Modules.Services;
using PenaticCore.Domain.Models;

namespace PenaticCore.Application.Helpers
{
    public static class UserApplicationCollectionExtensions
    {

        public static IServiceCollection AddUserApplication(this IServiceCollection services, IConfiguration config)
        {
            services.AddAutoMapper(typeof(AutoMapperProfiles).Assembly);
            services.AddScoped<IEmirateService, EmirateService>();
            services.AddScoped<IRegionService, RegionService>();
            return services;
        }

        public static void RegisterRepositories(this IServiceCollection services)
        {

            var assembly = typeof(EntityBase).Assembly;
            foreach (var type in assembly.GetTypes())
            {
                if (typeof(EntityBase).IsAssignableFrom(type) && type.Name != "EntityBase")
                {
                    var method = typeof(UserApplicationCollectionExtensions).GetMethod("AddUserRepository");
                    if (method != null)
                    {
                        var genericMethod = method.MakeGenericMethod(type);
                        genericMethod.Invoke(null, new object?[] { services });
                    }
                }
            }

        }

        public static void AddUserRepository<T>(IServiceCollection services)
      where T : EntityBase
        {
            services.AddScoped<IRepositoryBase<T>, RepositoryBase<T>>();

        }
    }
}
