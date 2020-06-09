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
    public partial class SimpleCalculatorPage : ContentPage
    {
        public SimpleCalculatorPage()
        {
            InitializeComponent();
        }

        private void btn_Clicked(object sender, EventArgs e)
        {
            double hasil = 0;
            var myButton = (Button)sender;
            switch (myButton.Text)
            {
                case "Tambah":
                    hasil = Convert.ToDouble(entryBil1.Text) + Convert.ToDouble(entryBil2.Text);
                    break;
                case "Kurang":
                    hasil = Convert.ToDouble(entryBil1.Text) - Convert.ToDouble(entryBil2.Text);
                    break;
                case "Kali":
                    hasil = Convert.ToDouble(entryBil1.Text) * Convert.ToDouble(entryBil2.Text);
                    break;
                case "Bagi":
                    hasil = Convert.ToDouble(entryBil1.Text) / Convert.ToDouble(entryBil2.Text);
                    break;
            }
            entryHasil.Text = hasil.ToString();
        }
    }
}