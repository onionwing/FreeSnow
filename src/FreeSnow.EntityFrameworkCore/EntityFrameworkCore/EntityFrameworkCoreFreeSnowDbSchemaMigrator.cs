using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using FreeSnow.Data;
using Volo.Abp.DependencyInjection;

namespace FreeSnow.EntityFrameworkCore;

public class EntityFrameworkCoreFreeSnowDbSchemaMigrator
    : IFreeSnowDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreFreeSnowDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the FreeSnowDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<FreeSnowDbContext>()
            .Database
            .MigrateAsync();
    }
}
