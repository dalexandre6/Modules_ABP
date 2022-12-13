using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace MainAppn.Data;

/* This is used if database provider does't define
 * IMainAppnDbSchemaMigrator implementation.
 */
public class NullMainAppnDbSchemaMigrator : IMainAppnDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
