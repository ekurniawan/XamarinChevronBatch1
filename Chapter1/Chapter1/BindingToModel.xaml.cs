using Chapter1.Models;
using Chapter1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Chapter1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BindingToModel : ContentPage
    {
       
        public BindingToModel()
        {
            InitializeComponent();
          
            BindingContext = new ListDataViewModel();
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            ListItem item = (ListItem)e.Item;
            DisplayAlert("Keterangan", $"Title: {item.Title} Desc: {item.Description}", "OK");
            ((ListView)sender).SelectedItem = null;
        }
    }
}