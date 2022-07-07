using Ayandeh.Faraz.Models.Tenants;
using Ayandeh.Faraz.ViewModels;
using Xamarin.Forms;

namespace Ayandeh.Faraz.Views
{
    public partial class TenantsView : ContentPage, IXamarinView
    {
        public TenantsView()
        {
            InitializeComponent();
        }

        private async void ListView_OnItemAppearing(object sender, ItemVisibilityEventArgs e)
        {
            await ((TenantsViewModel)BindingContext).LoadMoreTenantsIfNeedsAsync(e.Item as TenantListModel);
        }
    }
}