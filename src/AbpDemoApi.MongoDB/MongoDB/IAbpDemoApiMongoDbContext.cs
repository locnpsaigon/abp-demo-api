using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace AbpDemoApi.MongoDB;

[ConnectionStringName(AbpDemoApiDbProperties.ConnectionStringName)]
public interface IAbpDemoApiMongoDbContext : IAbpMongoDbContext
{
    /* Define mongo collections here. Example:
     * IMongoCollection<Question> Questions { get; }
     */
}
