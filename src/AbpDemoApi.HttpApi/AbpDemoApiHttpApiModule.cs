using AbpDemoApi.Localization;
using Localization.Resources.AbpUi;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;

namespace AbpDemoApi;

[DependsOn(
    typeof(AbpDemoApiApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class AbpDemoApiHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(AbpDemoApiHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<AbpDemoApiResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
