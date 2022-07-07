using Ayandeh.Faraz.Models.Users;
using Ayandeh.Faraz.ViewModels;
using Xamarin.Forms;

namespace Ayandeh.Faraz.Views
{
    public partial class UsersView : ContentPage, IXamarinView
    {
        public UsersView()
        {
            InitializeComponent();
        }

        public async void ListView_OnItemAppearing(object sender, ItemVisibilityEventArgs e)
        {
            await ((UsersViewModel) BindingContext).LoadMoreUserIfNeedsAsync(e.Item as UserListModel);
        }
    }
}