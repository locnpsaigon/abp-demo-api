using Volo.Abp;
using Volo.Abp.MongoDB;

namespace AbpDemoApi.MongoDB;

public static class AbpDemoApiMongoDbContextExtensions
{
    public static void ConfigureAbpDemoApi(
        this IMongoModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));
    }
}
