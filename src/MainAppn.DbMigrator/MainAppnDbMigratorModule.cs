using MainAppn.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace MainAppn.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(MainAppnEntityFrameworkCoreModule),
    typeof(MainAppnApplicationContractsModule)
    )]
public class MainAppnDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
