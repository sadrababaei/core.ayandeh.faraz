using System.Collections.Generic;
using Ayandeh.Faraz.DynamicEntityProperties.Dto;

namespace Ayandeh.Faraz.Web.Areas.App.Models.DynamicEntityProperty
{
    public class CreateEntityDynamicPropertyViewModel
    {
        public string EntityFullName { get; set; }

        public List<string> AllEntities { get; set; }

        public List<DynamicPropertyDto> DynamicProperties { get; set; }
    }
}
