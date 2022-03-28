using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace TRABAJO_DEL_CURSO.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "DATOS DEL ALUMNO";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://github.com/Gysmoy"));
        }

        public ICommand OpenWebCommand { get; }
    }
}