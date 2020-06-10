using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Chapter1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyMasterDetailPageMaster : ContentPage
    {
        public ListView ListView;

        public MyMasterDetailPageMaster()
        {
            InitializeComponent();

            BindingContext = new MyMasterDetailPageMasterViewModel();
            ListView = MenuItemsListView;
        }

        class MyMasterDetailPageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MyMasterDetailPageMasterMenuItem> MenuItems { get; set; }

            public MyMasterDetailPageMasterViewModel()
            {
                MenuItems = new ObservableCollection<MyMasterDetailPageMasterMenuItem>(new[]
                {
                    new MyMasterDetailPageMasterMenuItem { Id = 0, Title = "Simple List",
                        TargetType=typeof(BindingListString)},
                    new MyMasterDetailPageMasterMenuItem { Id = 1, Title = "Image List",
                        TargetType=typeof(ListViewImageCell)},
                    new MyMasterDetailPageMasterMenuItem { Id = 2, Title = "Custom List",
                        TargetType=typeof(CustomListViewPage)},
                    new MyMasterDetailPageMasterMenuItem { Id = 3, Title = "Alert",
                        TargetType=typeof(AlertPage)},
                    new MyMasterDetailPageMasterMenuItem { Id = 4, Title = "Progress",
                        TargetType=typeof(ProgressPage)},
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}