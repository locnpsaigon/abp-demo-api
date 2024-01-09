using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace AbpDemoApi;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(AbpDemoApiDomainSharedModule)
)]
public class AbpDemoApiDomainModule : AbpModule
{

}
