using System;
using System.Collections.Generic;
using System.Text;
using FreeSnow.Localization;
using Volo.Abp.Application.Services;

namespace FreeSnow;

/* Inherit your application services from this class.
 */
public abstract class FreeSnowAppService : ApplicationService
{
    protected FreeSnowAppService()
    {
        LocalizationResource = typeof(FreeSnowResource);
    }
}
