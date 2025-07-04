using Volo.Abp.Modularity;

namespace FreeSnow;

/* Inherit from this class for your domain layer tests. */
public abstract class FreeSnowDomainTestBase<TStartupModule> : FreeSnowTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
