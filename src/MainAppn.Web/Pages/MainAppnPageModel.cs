using MainAppn.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace MainAppn.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class MainAppnPageModel : AbpPageModel
{
    protected MainAppnPageModel()
    {
        LocalizationResourceType = typeof(MainAppnResource);
    }
}
