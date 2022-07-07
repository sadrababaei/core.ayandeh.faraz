namespace Ayandeh.Faraz.Services.Permission
{
    public interface IPermissionService
    {
        bool HasPermission(string key);
    }
}