using System.Collections.Generic;
using Ayandeh.Faraz.Editions.Dto;

namespace Ayandeh.Faraz.Web.Areas.App.Models.Tenants
{
    public class TenantIndexViewModel
    {
        public List<SubscribableEditionComboboxItemDto> EditionItems { get; set; }
    }
}