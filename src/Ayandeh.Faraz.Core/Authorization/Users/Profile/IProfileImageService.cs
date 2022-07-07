using Abp;
using Abp.Domain.Services;
using System.Threading.Tasks;

namespace Ayandeh.Faraz.Authorization.Users.Profile
{
    public interface IProfileImageService : IDomainService
    {
        Task<string> GetProfilePictureContentForUser(UserIdentifier userIdentifier);
    }
}