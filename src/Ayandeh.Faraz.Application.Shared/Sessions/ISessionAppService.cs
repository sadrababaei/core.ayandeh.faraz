using System.Threading.Tasks;
using Abp.Application.Services;
using Ayandeh.Faraz.Sessions.Dto;

namespace Ayandeh.Faraz.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();

        Task<UpdateUserSignInTokenOutput> UpdateUserSignInToken();
    }
}
