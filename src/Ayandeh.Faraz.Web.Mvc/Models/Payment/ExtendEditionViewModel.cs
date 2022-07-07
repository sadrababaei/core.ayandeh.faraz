using System.Collections.Generic;
using Ayandeh.Faraz.Editions.Dto;
using Ayandeh.Faraz.MultiTenancy.Payments;

namespace Ayandeh.Faraz.Web.Models.Payment
{
    public class ExtendEditionViewModel
    {
        public EditionSelectDto Edition { get; set; }

        public List<PaymentGatewayModel> PaymentGateways { get; set; }
    }
}