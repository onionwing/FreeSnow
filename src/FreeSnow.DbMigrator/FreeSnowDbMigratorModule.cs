using FreeSnow.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace FreeSnow.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(FreeSnowEntityFrameworkCoreModule),
    typeof(FreeSnowApplicationContractsModule)
    )]
public class FreeSnowDbMigratorModule : AbpModule
{
}
