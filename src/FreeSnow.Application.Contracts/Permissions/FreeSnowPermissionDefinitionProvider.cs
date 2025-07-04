using FreeSnow.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace FreeSnow.Permissions;

public class FreeSnowPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(FreeSnowPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(FreeSnowPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<FreeSnowResource>(name);
    }
}
