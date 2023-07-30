using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Diagnostics;

namespace Login
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void checkAccount(object sender, EventArgs e)
        {
            string sUsername = txtUsername.Text;
            string sPassword = txtPassword.Text;

            if ((sUsername == "Butcher") && (sPassword == "Loquendo64"))
            {
                Navigation.PushAsync(new Efecto());

            }
            else
            {
                DisplayAlert("Alert", "El Usuario o el Password Son Incorrectos", "OK");
            }
        }

    }

}

