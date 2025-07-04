using Volo.Abp.Modularity;

namespace FreeSnow;

public abstract class FreeSnowApplicationTestBase<TStartupModule> : FreeSnowTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
