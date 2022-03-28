using System;
using System.Collections.Generic;
using System.Text;
using TRABAJO_DEL_CURSO.Views;
using Xamarin.Forms;

namespace TRABAJO_DEL_CURSO.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public Command AboutCommand { get; }
        public Command WorkCommand { get; }

        public LoginViewModel()
        {
            AboutCommand = new Command(OnAboutClicked);
            WorkCommand = new Command(OnWorkClicked);
        }

        private async void OnAboutClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
        }

        private async void OnWorkClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            await Shell.Current.GoToAsync($"//{nameof(ItemsPage)}");
        }
    }
}
