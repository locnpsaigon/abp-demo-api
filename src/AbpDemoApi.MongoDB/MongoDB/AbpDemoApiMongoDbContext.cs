using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace AbpDemoApi.MongoDB;

[ConnectionStringName(AbpDemoApiDbProperties.ConnectionStringName)]
public class AbpDemoApiMongoDbContext : AbpMongoDbContext, IAbpDemoApiMongoDbContext
{
    /* Add mongo collections here. Example:
     * public IMongoCollection<Question> Questions => Collection<Question>();
     */

    protected override void CreateModel(IMongoModelBuilder modelBuilder)
    {
        base.CreateModel(modelBuilder);

        modelBuilder.ConfigureAbpDemoApi();
    }
}
