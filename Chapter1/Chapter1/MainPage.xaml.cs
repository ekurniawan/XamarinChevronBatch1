﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Chapter1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            btnTambah.Clicked += BtnTambah_Clicked;
        }

        private void BtnTambah_Clicked(object sender, EventArgs e)
        {
            //DisplayAlert("Keterangan", "Button Tambah", "OK");
            btnSubmit.BackgroundColor = SharedResources.ButtonBkColor;
        }

        //menambahkan event handler
        private void btnSubmit_Clicked(object sender, EventArgs e)
        {
            string firstName = entryFirstName.Text;
            string lastName = entryLastName.Text;
            DisplayAlert("Keterangan",$"Nama anda adalah: {firstName} {lastName}","OK");
        }

        private void btnHello_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Keterangan", "Hello Xamarin", "OK");
        }
    }
}
