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
    public partial class BindingListString : ContentPage
    {
        public BindingListString()
        {
            InitializeComponent();
            List<string> lstBarang = new List<string> { "Motherboard","Monitor","Mouse",
                "RAM", "SSD Hardisk" };
            lvData.ItemsSource = lstBarang;
        }
    }
}