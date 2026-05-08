using PassXYZ.Vault.ViewModels;
using KPCLib;
using System.ComponentModel;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using System.Diagnostics;

namespace PassXYZ.Vault.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }

        void OnFieldSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var field = args.SelectedItem as Field;
            if (field == null)
            {
                Debug.WriteLine("OnFieldSelected: Field is null.");
                return;
            }
        }
    }
}