using System.Threading.Tasks;

namespace FreeSnow.Data;

public interface IFreeSnowDbSchemaMigrator
{
    Task MigrateAsync();
}
