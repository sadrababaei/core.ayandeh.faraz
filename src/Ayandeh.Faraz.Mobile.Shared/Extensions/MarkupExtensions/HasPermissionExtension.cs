using System;
using Ayandeh.Faraz.Core;
using Ayandeh.Faraz.Core.Dependency;
using Ayandeh.Faraz.Services.Permission;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ayandeh.Faraz.Extensions.MarkupExtensions
{
    [ContentProperty("Text")]
    public class HasPermissionExtension : IMarkupExtension
    {
        public string Text { get; set; }
        
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (ApplicationBootstrapper.AbpBootstrapper == null || Text == null)
            {
                return false;
            }

            var permissionService = DependencyResolver.Resolve<IPermissionService>();
            return permissionService.HasPermission(Text);
        }
    }
}