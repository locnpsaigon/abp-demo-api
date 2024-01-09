using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace AbpDemoApi;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AbpDemoApiHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class AbpDemoApiConsoleApiClientModule : AbpModule
{

}
