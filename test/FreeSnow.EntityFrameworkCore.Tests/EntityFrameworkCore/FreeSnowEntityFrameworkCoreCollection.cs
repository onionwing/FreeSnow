using Xunit;

namespace FreeSnow.EntityFrameworkCore;

[CollectionDefinition(FreeSnowTestConsts.CollectionDefinitionName)]
public class FreeSnowEntityFrameworkCoreCollection : ICollectionFixture<FreeSnowEntityFrameworkCoreFixture>
{

}
