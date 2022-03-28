using System;
using System.Collections.Generic;
using TRABAJO_DEL_CURSO.ViewModels;
using TRABAJO_DEL_CURSO.Views;
using Xamarin.Forms;

namespace TRABAJO_DEL_CURSO
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
