using AbpDemoApi.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AbpDemoApi.Permissions;

public class AbpDemoApiPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(AbpDemoApiPermissions.GroupName, L("Permission:AbpDemoApi"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AbpDemoApiResource>(name);
    }
}
