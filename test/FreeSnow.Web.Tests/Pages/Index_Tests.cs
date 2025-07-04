using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace FreeSnow.Pages;

public class Index_Tests : FreeSnowWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
