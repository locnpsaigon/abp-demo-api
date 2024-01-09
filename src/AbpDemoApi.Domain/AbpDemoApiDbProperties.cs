namespace AbpDemoApi;

public static class AbpDemoApiDbProperties
{
    public static string DbTablePrefix { get; set; } = "";

    public static string? DbSchema { get; set; } = null;

    public const string ConnectionStringName = "AbpDemoApi";
}
