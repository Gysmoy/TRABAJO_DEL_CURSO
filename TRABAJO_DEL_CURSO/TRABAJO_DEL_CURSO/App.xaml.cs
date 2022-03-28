using System;
using TRABAJO_DEL_CURSO.Services;
using TRABAJO_DEL_CURSO.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TRABAJO_DEL_CURSO
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
