using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace DatabaseAccess.Data
{
    public class BreederContextFactory: IDesignTimeDbContextFactory<BreederContext>
    {
        public BreederContext CreateDbContext(string[] args)
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false)
                .Build();

            var builder = new DbContextOptionsBuilder<BreederContext>();
            builder.UseSqlServer(config.GetConnectionString(Breeder.Common.Configurations.DefaultConnection));
            return new BreederContext(builder.Options);

            //dotnet ef migrations add InitialCreate
           // builder.UseSqlServer("Server=mssql6.gear.host;Database=frenchbulldog;User ID=frenchbulldog; Password=!qwerty1");
       
        }
    }
}
