﻿using System.Threading.Tasks;
using Abp.Application.Services;
using Ayandeh.Faraz.Configuration.Host.Dto;

namespace Ayandeh.Faraz.Configuration.Host
{
    public interface IHostSettingsAppService : IApplicationService
    {
        Task<HostSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(HostSettingsEditDto input);

        Task SendTestEmail(SendTestEmailInput input);
    }
}
