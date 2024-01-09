using Volo.Abp.Modularity;

namespace AbpDemoApi;

[DependsOn(
    typeof(AbpDemoApiApplicationModule),
    typeof(AbpDemoApiDomainTestModule)
    )]
public class AbpDemoApiApplicationTestModule : AbpModule
{

}
