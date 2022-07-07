using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Ayandeh.Faraz.MultiTenancy.HostDashboard.Dto;

namespace Ayandeh.Faraz.MultiTenancy.HostDashboard
{
    public interface IIncomeStatisticsService
    {
        Task<List<IncomeStastistic>> GetIncomeStatisticsData(DateTime startDate, DateTime endDate,
            ChartDateInterval dateInterval);
    }
}