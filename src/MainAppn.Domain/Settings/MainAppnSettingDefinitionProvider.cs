using Volo.Abp.Settings;

namespace MainAppn.Settings;

public class MainAppnSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(MainAppnSettings.MySetting1));
    }
}
