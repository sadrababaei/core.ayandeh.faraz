﻿using System.Threading.Tasks;
using Ayandeh.Faraz.Views;
using Xamarin.Forms;

namespace Ayandeh.Faraz.Services.Modal
{
    public interface IModalService
    {
        Task ShowModalAsync(Page page);

        Task ShowModalAsync<TView>(object navigationParameter) where TView : IXamarinView;

        Task<Page> CloseModalAsync();
    }
}
