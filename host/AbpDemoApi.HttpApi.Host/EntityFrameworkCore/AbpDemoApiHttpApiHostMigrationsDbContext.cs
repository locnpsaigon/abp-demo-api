using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace AbpDemoApi.EntityFrameworkCore;

public class AbpDemoApiHttpApiHostMigrationsDbContext : AbpDbContext<AbpDemoApiHttpApiHostMigrationsDbContext>
{
    public AbpDemoApiHttpApiHostMigrationsDbContext(DbContextOptions<AbpDemoApiHttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureAbpDemoApi();
    }
}
