using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace AbpDemoApi;

[DependsOn(
    typeof(AbpVirtualFileSystemModule)
    )]
public class AbpDemoApiInstallerModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<AbpDemoApiInstallerModule>();
        });
    }
}
