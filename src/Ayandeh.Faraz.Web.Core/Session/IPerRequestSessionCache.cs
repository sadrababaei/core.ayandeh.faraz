using System.Threading.Tasks;
using Ayandeh.Faraz.Sessions.Dto;

namespace Ayandeh.Faraz.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}
