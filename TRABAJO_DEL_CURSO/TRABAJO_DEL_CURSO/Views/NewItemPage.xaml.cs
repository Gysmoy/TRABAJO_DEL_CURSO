using System;
using System.Collections.Generic;
using System.ComponentModel;
using TRABAJO_DEL_CURSO.Models;
using TRABAJO_DEL_CURSO.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TRABAJO_DEL_CURSO.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}