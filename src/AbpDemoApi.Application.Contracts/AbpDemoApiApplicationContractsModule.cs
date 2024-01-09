using Volo.Abp.Application;
using Volo.Abp.Authorization;
using Volo.Abp.Modularity;

namespace AbpDemoApi;

[DependsOn(
    typeof(AbpDemoApiDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class AbpDemoApiApplicationContractsModule : AbpModule
{

}
