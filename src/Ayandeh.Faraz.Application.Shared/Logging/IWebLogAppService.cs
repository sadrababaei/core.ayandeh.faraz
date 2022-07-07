using Abp.Application.Services;
using Ayandeh.Faraz.Dto;
using Ayandeh.Faraz.Logging.Dto;

namespace Ayandeh.Faraz.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}
