using System.Threading.Tasks;

namespace MainAppn.Data;

public interface IMainAppnDbSchemaMigrator
{
    Task MigrateAsync();
}
