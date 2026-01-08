using AbpSolution2.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace AbpSolution2.Permissions;

public class AbpSolution2PermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(AbpSolution2Permissions.GroupName);

        var booksPermission = myGroup.AddPermission(AbpSolution2Permissions.Books.Default, L("Permission:Books"));
        booksPermission.AddChild(AbpSolution2Permissions.Books.Create, L("Permission:Books.Create"));
        booksPermission.AddChild(AbpSolution2Permissions.Books.Edit, L("Permission:Books.Edit"));
        booksPermission.AddChild(AbpSolution2Permissions.Books.Delete, L("Permission:Books.Delete"));
        //Define your own permissions here. Example:
        //myGroup.AddPermission(AbpSolution2Permissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AbpSolution2Resource>(name);
    }
}
