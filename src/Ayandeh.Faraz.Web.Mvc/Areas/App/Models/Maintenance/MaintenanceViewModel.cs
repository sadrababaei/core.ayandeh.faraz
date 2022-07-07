using System.Collections.Generic;
using Ayandeh.Faraz.Caching.Dto;

namespace Ayandeh.Faraz.Web.Areas.App.Models.Maintenance
{
    public class MaintenanceViewModel
    {
        public IReadOnlyList<CacheDto> Caches { get; set; }
    }
}