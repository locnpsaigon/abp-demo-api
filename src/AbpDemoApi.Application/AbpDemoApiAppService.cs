using AbpDemoApi.Localization;
using Volo.Abp.Application.Services;

namespace AbpDemoApi;

public abstract class AbpDemoApiAppService : ApplicationService
{
    protected AbpDemoApiAppService()
    {
        LocalizationResource = typeof(AbpDemoApiResource);
        ObjectMapperContext = typeof(AbpDemoApiApplicationModule);
    }
}
