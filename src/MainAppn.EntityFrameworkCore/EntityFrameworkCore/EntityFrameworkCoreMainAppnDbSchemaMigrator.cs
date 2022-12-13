using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MainAppn.Data;
using Volo.Abp.DependencyInjection;

namespace MainAppn.EntityFrameworkCore;

public class EntityFrameworkCoreMainAppnDbSchemaMigrator
    : IMainAppnDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreMainAppnDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the MainAppnDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<MainAppnDbContext>()
            .Database
            .MigrateAsync();
    }
}
