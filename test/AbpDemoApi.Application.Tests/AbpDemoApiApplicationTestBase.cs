using Volo.Abp.Modularity;

namespace AbpDemoApi;

/* Inherit from this class for your application layer tests.
 * See SampleAppService_Tests for example.
 */
public abstract class AbpDemoApiApplicationTestBase<TStartupModule> : AbpDemoApiTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
