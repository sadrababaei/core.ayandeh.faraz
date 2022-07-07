using System.Threading.Tasks;

namespace Ayandeh.Faraz.Security
{
    public interface IPasswordComplexitySettingStore
    {
        Task<PasswordComplexitySetting> GetSettingsAsync();
    }
}
