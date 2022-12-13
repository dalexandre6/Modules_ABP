using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace MainAppn.Pages;

public class Index_Tests : MainAppnWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
