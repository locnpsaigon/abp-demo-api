using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace AbpDemoApi.EntityFrameworkCore;

[ConnectionStringName(AbpDemoApiDbProperties.ConnectionStringName)]
public interface IAbpDemoApiDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
