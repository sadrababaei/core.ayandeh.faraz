using System.Threading.Tasks;
using Abp.Application.Services;
using Ayandeh.Faraz.MultiTenancy.HostDashboard.Dto;

namespace Ayandeh.Faraz.MultiTenancy.HostDashboard
{
    public interface IHostDashboardAppService : IApplicationService
    {
        Task<TopStatsData> GetTopStatsData(GetTopStatsInput input);

        Task<GetRecentTenantsOutput> GetRecentTenantsData();

        Task<GetExpiringTenantsOutput> GetSubscriptionExpiringTenantsData();

        Task<GetIncomeStatisticsDataOutput> GetIncomeStatistics(GetIncomeStatisticsDataInput input);

        Task<GetEditionTenantStatisticsOutput> GetEditionTenantStatistics(GetEditionTenantStatisticsInput input);
    }
}