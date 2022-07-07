using System;
using System.Threading.Tasks;
using Flurl.Http.Content;
using Ayandeh.Faraz.Authorization.Users.Profile.Dto;

namespace Ayandeh.Faraz.Authorization.Users.Profile
{
    public class ProxyProfileControllerService : ProxyControllerBase
    {
        public async Task<UploadProfilePictureOutput> UploadProfilePicture(Action<CapturedMultipartContent> buildContent)
        {
            return await ApiClient
                .PostMultipartAsync<UploadProfilePictureOutput>(GetEndpoint(nameof(UploadProfilePicture)), buildContent);
        }
    }
}