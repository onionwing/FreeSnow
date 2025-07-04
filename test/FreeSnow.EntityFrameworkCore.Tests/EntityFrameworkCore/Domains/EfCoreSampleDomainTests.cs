using FreeSnow.Samples;
using Xunit;

namespace FreeSnow.EntityFrameworkCore.Domains;

[Collection(FreeSnowTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<FreeSnowEntityFrameworkCoreTestModule>
{

}
