using System;
using DatabaseAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace BreederWeb
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<BreederContext>
    {
        public BreederContext CreateDbContext(string[] args)
        {
             IConfigurationRoot configuration = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("appsettings.json")
                 .Build();
            var builder = new DbContextOptionsBuilder<BreederContext>();
            //  var connectionString = configuration.GetConnectionString("DefaultConnection");
            builder.UseSqlServer("Server=mssql6.gear.host;Database=frenchbulldog;User ID=frenchbulldog; Password=!qwerty1");
            return new BreederContext(builder.Options);
        }
    }
}
