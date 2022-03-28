using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Input;
using TRABAJO_DEL_CURSO.Models;
using Xamarin.Forms;

namespace TRABAJO_DEL_CURSO.ViewModels
{
    public class NewItemViewModel : BaseViewModel
    {
        private string itemId;
        private string id;
        private string text;
        private string description;
        private string date;
        private string start;
        private string end;

        public NewItemViewModel()
        {
            SaveCommand = new Command(OnSave, ValidateSave);
            CancelCommand = new Command(OnCancel);
            this.PropertyChanged +=
                (_, __) => SaveCommand.ChangeCanExecute();
        }

        private bool ValidateSave()
        {
            return !String.IsNullOrWhiteSpace(text)
                && !String.IsNullOrWhiteSpace(description)
                && !String.IsNullOrWhiteSpace(date)
                && !String.IsNullOrWhiteSpace(start)
                && !String.IsNullOrWhiteSpace(end);
        }

        public string Id
        {
            get => text;
            set => SetProperty(ref text, value);
        }
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

        public Command SaveCommand { get; }
        public Command CancelCommand { get; }

        private async void OnCancel()
        {
            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }

        private async void OnSave()
        {
            Item newItem = new Item()
            {
                Id = Guid.NewGuid().ToString(),
                Text = Text,
                Description = Description,
                Date = Date,
                Start = Start,
                End = End
            };

            await DataStore.AddItemAsync(newItem);

            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }
    }
}
