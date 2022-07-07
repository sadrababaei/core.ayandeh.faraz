using System;
using Ayandeh.Faraz.Core;
using Ayandeh.Faraz.Localization;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ayandeh.Faraz.Extensions.MarkupExtensions
{
    [ContentProperty("Text")]
    public class TranslateExtension : IMarkupExtension
    {
        public string Text { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (ApplicationBootstrapper.AbpBootstrapper == null || Text == null)
            {
                return Text;
            }

            return L.Localize(Text);
        }
    }
}