using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace Chapter1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SamplePreferencePage : ContentPage
    {
        public SamplePreferencePage()
        {
            InitializeComponent();
        }

        private void btnBuatPreference_Clicked(object sender, EventArgs e)
        {
            Preferences.Set("color", "Red");
            Preferences.Set("id", "1234");
        }

        private void btnShowPreference_Clicked(object sender, EventArgs e)
        {
            var myColor = Preferences.Get("color", "Green").ToString();
            DisplayAlert("Preferences", $"Color: {myColor}", "OK");
        }

        private void btnEditPreference_Clicked(object sender, EventArgs e)
        {
            Preferences.Set("color", "Yellow");
        }
    }
}