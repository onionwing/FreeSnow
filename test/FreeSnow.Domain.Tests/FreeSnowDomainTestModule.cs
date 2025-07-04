using Volo.Abp.Modularity;

namespace FreeSnow;

[DependsOn(
    typeof(FreeSnowDomainModule),
    typeof(FreeSnowTestBaseModule)
)]
public class FreeSnowDomainTestModule : AbpModule
{

}
