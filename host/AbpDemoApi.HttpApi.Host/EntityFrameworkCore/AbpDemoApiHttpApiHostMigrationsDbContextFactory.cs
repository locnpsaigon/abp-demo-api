using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace AbpDemoApi.EntityFrameworkCore;

public class AbpDemoApiHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<AbpDemoApiHttpApiHostMigrationsDbContext>
{
    public AbpDemoApiHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<AbpDemoApiHttpApiHostMigrationsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("AbpDemoApi"));

        return new AbpDemoApiHttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
