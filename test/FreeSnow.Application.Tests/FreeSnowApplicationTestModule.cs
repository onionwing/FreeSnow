using Volo.Abp.Modularity;

namespace FreeSnow;

[DependsOn(
    typeof(FreeSnowApplicationModule),
    typeof(FreeSnowDomainTestModule)
)]
public class FreeSnowApplicationTestModule : AbpModule
{

}
