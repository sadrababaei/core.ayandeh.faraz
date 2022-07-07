using System.Threading.Tasks;
using Abp.Application.Services;
using Ayandeh.Faraz.Configuration.Tenants.Dto;

namespace Ayandeh.Faraz.Configuration.Tenants
{
    public interface ITenantSettingsAppService : IApplicationService
    {
        Task<TenantSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(TenantSettingsEditDto input);

        Task ClearLogo();

        Task ClearCustomCss();
    }
}
