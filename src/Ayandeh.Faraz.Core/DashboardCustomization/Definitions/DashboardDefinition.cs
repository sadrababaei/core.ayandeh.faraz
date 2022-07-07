using System.Collections.Generic;

namespace Ayandeh.Faraz.DashboardCustomization.Definitions
{
    public class DashboardDefinition
    {
        public string Name { get; set; }

        public List<string> AvailableWidgets { get; set; }

        public DashboardDefinition(string name, List<string> availableWidgets)
        {
            Name = name;
            AvailableWidgets = availableWidgets;
        }
    }
}
