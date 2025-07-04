using FreeSnow.Samples;
using Xunit;

namespace FreeSnow.EntityFrameworkCore.Applications;

[Collection(FreeSnowTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<FreeSnowEntityFrameworkCoreTestModule>
{

}
