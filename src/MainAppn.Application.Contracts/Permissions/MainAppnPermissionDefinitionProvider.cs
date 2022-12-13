using MainAppn.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace MainAppn.Permissions;

public class MainAppnPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(MainAppnPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(MainAppnPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<MainAppnResource>(name);
    }
}
