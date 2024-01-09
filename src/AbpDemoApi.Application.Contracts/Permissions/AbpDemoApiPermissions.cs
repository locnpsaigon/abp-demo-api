using Volo.Abp.Reflection;

namespace AbpDemoApi.Permissions;

public class AbpDemoApiPermissions
{
    public const string GroupName = "AbpDemoApi";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(AbpDemoApiPermissions));
    }
}
