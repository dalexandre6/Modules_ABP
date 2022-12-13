using MainAppn.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace MainAppn.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class MainAppnController : AbpControllerBase
{
    protected MainAppnController()
    {
        LocalizationResource = typeof(MainAppnResource);
    }
}
