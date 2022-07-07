using System.Collections.Generic;
using Ayandeh.Faraz.DashboardCustomization.Dto;

namespace Ayandeh.Faraz.Web.Areas.App.Models.CustomizableDashboard
{
    public class AddWidgetViewModel
    {
        public List<WidgetOutput> Widgets { get; set; }

        public string DashboardName { get; set; }

        public string PageId { get; set; }
    }
}
