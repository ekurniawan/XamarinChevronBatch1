using Chapter1.Models;
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
    public partial class BindingNoMVVM : ContentPage
    {
        private List<ListItem> lstItems;
        public BindingNoMVVM()
        {
            InitializeComponent();
            lstItems = new List<ListItem>
            {
                new ListItem{Title="Xamarin Android",Description="Belajar Xamarin for Android"},
                new ListItem{Title="Xamarin IOS",Description="Belajar Xamarin for IOS"},
                new ListItem{Title="Xamarin Cross Platform",Description="Belajar Xamarin Cross Platform"}
            };

            lvData.ItemsSource = lstItems;
        }
    }
}