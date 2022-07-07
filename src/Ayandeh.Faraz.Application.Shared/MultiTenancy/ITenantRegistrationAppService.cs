using System.Threading.Tasks;
using Abp.Application.Services;
using Ayandeh.Faraz.Editions.Dto;
using Ayandeh.Faraz.MultiTenancy.Dto;

namespace Ayandeh.Faraz.MultiTenancy
{
    public interface ITenantRegistrationAppService: IApplicationService
    {
        Task<RegisterTenantOutput> RegisterTenant(RegisterTenantInput input);

        Task<EditionsSelectOutput> GetEditionsForSelect();

        Task<EditionSelectDto> GetEdition(int editionId);
    }
}