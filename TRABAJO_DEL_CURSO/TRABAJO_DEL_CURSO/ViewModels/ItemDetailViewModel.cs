using System;
using System.Diagnostics;
using System.Threading.Tasks;
using TRABAJO_DEL_CURSO.Models;
using TRABAJO_DEL_CURSO.Views;
using Xamarin.Forms;

namespace TRABAJO_DEL_CURSO.ViewModels
{
    [QueryProperty(nameof(ItemId), nameof(ItemId))]
    public class ItemDetailViewModel : BaseViewModel
    {
        private string itemId;
        private string text;
        private string description;
        private string date;
        private string start;
        private string end;
        public string Id { get; set; }

        public string Text
        {
            get => text;
            set => SetProperty(ref text, value);
        }

        public string Description
        {
            get => description;
            set => SetProperty(ref description, value);
        }
        public string Date
        {
            get => date;
            set => SetProperty(ref date, value);
        }
        public string Start
        {
            get => start;
            set => SetProperty(ref start, value);
        }
        public string End
        {
            get => end;
            set => SetProperty(ref end, value);
        }

        public string ItemId
        {
            get
            {
                return itemId;
            }
            set
            {
                itemId = value;
                LoadItemId(value);
            }
        }

        public async void LoadItemId(string itemId)
        {
            try
            {
                var item = await DataStore.GetItemAsync(itemId);
                Id = item.Id;
                Text = item.Text;
                Description = item.Description;
                Date = item.Date;
                Start = item.Start;
                End = item.End;
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }
        async void OnItemEdit()
        {
            // This will push the ItemDetailPage onto the navigation stack
            await Shell.Current.GoToAsync($"{nameof(NewItemPage)}?{nameof(NewItemViewModel.ItemId)}={Id}");
        }
    }
}
