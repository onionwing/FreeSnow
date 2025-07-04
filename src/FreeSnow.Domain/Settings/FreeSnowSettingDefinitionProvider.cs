using Volo.Abp.Settings;

namespace FreeSnow.Settings;

public class FreeSnowSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(FreeSnowSettings.MySetting1));
    }
}
