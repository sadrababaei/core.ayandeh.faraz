using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Ayandeh.Faraz.MultiTenancy.Accounting.Dto;

namespace Ayandeh.Faraz.MultiTenancy.Accounting
{
    public interface IInvoiceAppService
    {
        Task<InvoiceDto> GetInvoiceInfo(EntityDto<long> input);

        Task CreateInvoice(CreateInvoiceDto input);
    }
}
