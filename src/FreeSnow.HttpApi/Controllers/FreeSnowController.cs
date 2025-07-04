using FreeSnow.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace FreeSnow.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class FreeSnowController : AbpControllerBase
{
    protected FreeSnowController()
    {
        LocalizationResource = typeof(FreeSnowResource);
    }
}
