using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Chapter1.Models
{
    public class Student : BindableObject
    {
        private string id;
        public string ID
        {
            get { return id; }
            set { id = value; OnPropertyChanged("ID"); }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged("Name"); }
        }
    }
}
