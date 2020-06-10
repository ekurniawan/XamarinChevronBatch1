using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Chapter1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //application current
            Application.Current.Properties["id"] = "erick";
            MainPage = new NavigationPage(new ContohNavigasiPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
