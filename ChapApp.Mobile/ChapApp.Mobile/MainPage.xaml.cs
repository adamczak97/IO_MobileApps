﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ChapApp.Mobile
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            btnLogin.Clicked += BtnLogin_Clicked;
        }

        private async void BtnLogin_Clicked(object sender, EventArgs e)
        {
            var userName = txtLogin.Text;

            if(string.IsNullOrEmpty(userName))
            {
                await DisplayAlert("Validation errors", "The user name is required.", "Ok");
                return;
            }

            await Navigation.PushAsync(new ChatPage(userName));
        }
    }
}
