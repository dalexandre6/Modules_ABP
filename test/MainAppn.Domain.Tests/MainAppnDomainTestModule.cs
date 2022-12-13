using MainAppn.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace MainAppn;

[DependsOn(
    typeof(MainAppnEntityFrameworkCoreTestModule)
    )]
public class MainAppnDomainTestModule : AbpModule
{

}
