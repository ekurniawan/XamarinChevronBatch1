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
    public partial class ImageViewPage : ContentPage
    {
        public ImageViewPage()
        {
            InitializeComponent();
        }

        async private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Image image = (Image)sender;
            await image.FadeTo(0.5, 450);
            await Task.Delay(1000);
            await image.FadeTo(1, 450);
        }
    }
}