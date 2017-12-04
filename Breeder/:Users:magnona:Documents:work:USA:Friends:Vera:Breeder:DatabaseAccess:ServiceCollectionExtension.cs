using System;
using DatabaseAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DatabaseAccess
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddDatabaseServices(this IServiceCollection services, IConfiguration configuration)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            if (configuration == null)
            {
                throw new ArgumentNullException(nameof(configuration));
            }

             services.AddDbContext<BreederContext>(options => 
                                                   options.UseSqlServer(configuration.GetConnectionString(Breeder.Common.Configurations.DefaultConnection)));

            return services;
        }
    }
}
