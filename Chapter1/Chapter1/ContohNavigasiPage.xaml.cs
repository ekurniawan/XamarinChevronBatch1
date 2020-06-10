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
    public partial class ContohNavigasiPage : ContentPage
    {
        public ContohNavigasiPage()
        {
            InitializeComponent();
        }

        private async void btnNavSimpleList_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BindingListString(entryName.Text));
        }

        private async void btnNavImageList_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListViewImageCell());
        }
    }
}