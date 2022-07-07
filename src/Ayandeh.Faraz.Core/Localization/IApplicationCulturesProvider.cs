using System.Globalization;

namespace Ayandeh.Faraz.Localization
{
    public interface IApplicationCulturesProvider
    {
        CultureInfo[] GetAllCultures();
    }
}