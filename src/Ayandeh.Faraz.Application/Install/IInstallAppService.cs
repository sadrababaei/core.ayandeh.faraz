using System.Threading.Tasks;
using Abp.Application.Services;
using Ayandeh.Faraz.Install.Dto;

namespace Ayandeh.Faraz.Install
{
    public interface IInstallAppService : IApplicationService
    {
        Task Setup(InstallDto input);

        AppSettingsJsonDto GetAppSettingsJson();

        CheckDatabaseOutput CheckDatabase();
    }
}