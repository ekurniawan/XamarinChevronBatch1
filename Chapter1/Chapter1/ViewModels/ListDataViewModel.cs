using Chapter1.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Chapter1.ViewModels
{
    public class ListDataViewModel : BindableObject
    {
        private List<ListItem> lstItems;
        public ListDataViewModel()
        {
            lstItems = new List<ListItem>
            {
                new ListItem{Title="Xamarin Android",
                    Description="Belajar Xamarin for Android",Source="monkey.png",
                    Category="Mobile Programming"},
                new ListItem{Title="Xamarin IOS",Description="Belajar Xamarin for IOS",
                    Source="monkey.png",Category="Mobile Programming"},
                new ListItem{Title="Xamarin Cross Platform",
                    Description="Belajar Xamarin Cross Platform",Source="monkey.png",
                    Category="Web Programming"}
            };
        }

        public List<ListItem> ListItems
        {
            get { return lstItems; }
            set
            {
                lstItems = value;
                OnPropertyChanged("ListItems");
            }
        }
    }
}
