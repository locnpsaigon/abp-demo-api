using Volo.Abp.Modularity;

namespace AbpDemoApi;

[DependsOn(
    typeof(AbpDemoApiDomainModule),
    typeof(AbpDemoApiTestBaseModule)
)]
public class AbpDemoApiDomainTestModule : AbpModule
{

}
