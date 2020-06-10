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
    public partial class AlertPage : ContentPage
    {
        public AlertPage()
        {
            InitializeComponent();
        }

        private async void btnAlert_Clicked(object sender, EventArgs e)
        {
            var jawaban = await DisplayAlert("Keterangan", "Apakah anda setuju?", "Yes", "No");
            await DisplayAlert("Keterangan", $"Anda menjawab {jawaban}", "OK");
        }

        private async void btnActionSheet_Clicked(object sender, EventArgs e)
        {
            var hasil = await DisplayActionSheet("Kirim Ke?", "Cancel", null, "Twitter", "Facebook", "Tiktok");
            await DisplayAlert("Keterangan", $"Anda memilih {hasil}","OK");
        }
    }
}