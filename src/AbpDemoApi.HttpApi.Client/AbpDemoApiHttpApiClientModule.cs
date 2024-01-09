using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace AbpDemoApi;

[DependsOn(
    typeof(AbpDemoApiApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class AbpDemoApiHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(AbpDemoApiApplicationContractsModule).Assembly,
            AbpDemoApiRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<AbpDemoApiHttpApiClientModule>();
        });

    }
}
