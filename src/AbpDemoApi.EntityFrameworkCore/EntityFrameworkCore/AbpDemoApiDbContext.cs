using AbpDemoApi.Entities;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace AbpDemoApi.EntityFrameworkCore;

[ConnectionStringName(AbpDemoApiDbProperties.ConnectionStringName)]
public class AbpDemoApiDbContext : AbpDbContext<AbpDemoApiDbContext>, IAbpDemoApiDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public DbSet<Book> Books { get; set; }
    
    public AbpDemoApiDbContext(DbContextOptions<AbpDemoApiDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureAbpDemoApi();
    }
}
