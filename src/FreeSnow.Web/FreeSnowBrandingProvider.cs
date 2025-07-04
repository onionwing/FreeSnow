using Microsoft.Extensions.Localization;
using FreeSnow.Localization;
using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace FreeSnow.Web;

[Dependency(ReplaceServices = true)]
public class FreeSnowBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<FreeSnowResource> _localizer;

    public FreeSnowBrandingProvider(IStringLocalizer<FreeSnowResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
