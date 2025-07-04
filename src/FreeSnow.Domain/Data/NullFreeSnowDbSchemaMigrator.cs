using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace FreeSnow.Data;

/* This is used if database provider does't define
 * IFreeSnowDbSchemaMigrator implementation.
 */
public class NullFreeSnowDbSchemaMigrator : IFreeSnowDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
