using Volo.Abp.Modularity;

namespace AbpDemoApi;

/* Inherit from this class for your domain layer tests.
 * See SampleManager_Tests for example.
 */
public abstract class AbpDemoApiDomainTestBase<TStartupModule> : AbpDemoApiTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
