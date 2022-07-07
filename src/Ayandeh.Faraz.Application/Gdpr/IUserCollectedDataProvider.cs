using System.Collections.Generic;
using System.Threading.Tasks;
using Abp;
using Ayandeh.Faraz.Dto;

namespace Ayandeh.Faraz.Gdpr
{
    public interface IUserCollectedDataProvider
    {
        Task<List<FileDto>> GetFiles(UserIdentifier user);
    }
}
