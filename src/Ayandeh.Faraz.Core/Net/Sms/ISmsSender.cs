using System.Threading.Tasks;

namespace Ayandeh.Faraz.Net.Sms
{
    public interface ISmsSender
    {
        Task SendAsync(string number, string message);
    }
}