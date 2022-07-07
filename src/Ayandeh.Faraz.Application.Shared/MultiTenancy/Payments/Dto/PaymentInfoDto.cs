using Ayandeh.Faraz.Editions.Dto;

namespace Ayandeh.Faraz.MultiTenancy.Payments.Dto
{
    public class PaymentInfoDto
    {
        public EditionSelectDto Edition { get; set; }

        public decimal AdditionalPrice { get; set; }

        public bool IsLessThanMinimumUpgradePaymentAmount()
        {
            return AdditionalPrice < FarazConsts.MinimumUpgradePaymentAmount;
        }
    }
}
