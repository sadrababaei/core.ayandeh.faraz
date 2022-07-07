using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Ayandeh.Faraz.Authorization.Permissions.Dto;

namespace Ayandeh.Faraz.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}
