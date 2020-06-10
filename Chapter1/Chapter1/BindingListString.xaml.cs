using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Chapter1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BindingListString : ContentPage
    {
        private string _firstName;
        private void InisialisasiData()
        {
            InitializeComponent();
            List<string> lstBarang = new List<string> { "Motherboard","Monitor","Mouse",
                "RAM", "SSD Hardisk" };
            lvData.ItemsSource = lstBarang;

            lvData.ItemTapped += LvData_ItemTapped;
        }

        public BindingListString()
        {
            InisialisasiData();
        }

        public BindingListString(string firstName)
        {
            InisialisasiData();
            _firstName = firstName;
        }

        private void LvData_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            DisplayAlert("Keterangan",
                $"Anda mengakses data {e.Item} sudah dipilih", 
                 "OK");
            ((ListView)sender).SelectedItem = null;
        }

        private async void btnBack_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private void btnShowParam_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Parameter", $"Nilai param: {_firstName}", "OK");
        }

        private void btnAppCurrent_Clicked(object sender, EventArgs e)
        {
            var id = Application.Current.Properties["id"].ToString();
            DisplayAlert("App Current", $"ID anda : {id}", "OK");
        }
    }
}