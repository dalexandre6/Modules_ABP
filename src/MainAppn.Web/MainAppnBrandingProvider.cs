using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace MainAppn.Web;

[Dependency(ReplaceServices = true)]
public class MainAppnBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "MainAppn";
}
