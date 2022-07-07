using System.Threading.Tasks;
using Abp.Domain.Policies;

namespace Ayandeh.Faraz.Authorization.Users
{
    public interface IUserPolicy : IPolicy
    {
        Task CheckMaxUserCountAsync(int tenantId);
    }
}
