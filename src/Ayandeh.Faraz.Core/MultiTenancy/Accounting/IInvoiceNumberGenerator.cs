using System.Threading.Tasks;
using Abp.Dependency;

namespace Ayandeh.Faraz.MultiTenancy.Accounting
{
    public interface IInvoiceNumberGenerator : ITransientDependency
    {
        Task<string> GetNewInvoiceNumber();
    }
}