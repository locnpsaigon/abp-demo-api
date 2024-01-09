using AbpDemoApi.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AbpDemoApi;

public abstract class AbpDemoApiController : AbpControllerBase
{
    protected AbpDemoApiController()
    {
        LocalizationResource = typeof(AbpDemoApiResource);
    }
}
