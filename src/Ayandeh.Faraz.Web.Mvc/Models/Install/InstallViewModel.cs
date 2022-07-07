using System.Collections.Generic;
using Abp.Localization;
using Ayandeh.Faraz.Install.Dto;

namespace Ayandeh.Faraz.Web.Models.Install
{
    public class InstallViewModel
    {
        public List<ApplicationLanguage> Languages { get; set; }

        public AppSettingsJsonDto AppSettingsJson { get; set; }
    }
}
