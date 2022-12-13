using System;
using System.Collections.Generic;
using System.Text;
using MainAppn.Localization;
using Volo.Abp.Application.Services;

namespace MainAppn;

/* Inherit your application services from this class.
 */
public abstract class MainAppnAppService : ApplicationService
{
    protected MainAppnAppService()
    {
        LocalizationResource = typeof(MainAppnResource);
    }
}
