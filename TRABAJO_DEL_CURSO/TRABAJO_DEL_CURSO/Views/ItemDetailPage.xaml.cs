using System.ComponentModel;
using TRABAJO_DEL_CURSO.ViewModels;
using Xamarin.Forms;

namespace TRABAJO_DEL_CURSO.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}