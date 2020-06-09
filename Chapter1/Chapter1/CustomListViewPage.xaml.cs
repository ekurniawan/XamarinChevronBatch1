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
    public partial class CustomListViewPage : ContentPage
    {
        public CustomListViewPage()
        {
            InitializeComponent();
            BindingContext = new ListDataViewModel();
        }
    }
}