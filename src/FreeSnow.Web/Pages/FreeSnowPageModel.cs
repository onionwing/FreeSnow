using FreeSnow.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace FreeSnow.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class FreeSnowPageModel : AbpPageModel
{
    protected FreeSnowPageModel()
    {
        LocalizationResourceType = typeof(FreeSnowResource);
    }
}
