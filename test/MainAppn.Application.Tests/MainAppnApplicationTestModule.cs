using Volo.Abp.Modularity;

namespace MainAppn;

[DependsOn(
    typeof(MainAppnApplicationModule),
    typeof(MainAppnDomainTestModule)
    )]
public class MainAppnApplicationTestModule : AbpModule
{

}
