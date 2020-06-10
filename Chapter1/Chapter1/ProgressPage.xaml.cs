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
    public partial class ProgressPage : ContentPage
    {
        public ProgressPage()
        {
            InitializeComponent();
        }

        /*protected async override void OnAppearing()
        {
            base.OnAppearing();
            await myProgress.ProgressTo(1, 1000, Easing.Linear);
        }*/

        private async void btnProgress_Clicked(object sender, EventArgs e)
        {
            myProgress.Progress = 0.2;
           
            await myProgress.ProgressTo(1,10000, Easing.Linear);
        }
    }
}