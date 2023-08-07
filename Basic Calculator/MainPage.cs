using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace calculadoraBasica
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void add_btn(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(num1.Text) && !string.IsNullOrEmpty(num2.Text))
            {
                var a = double.Parse(num1.Text);
                var b = double.Parse(num2.Text);

                res.Text = (a + b).ToString();
                DisplayAlert("✔ Resultado", "El Resultado es:" + res.Text, "OK");



            }

            else
            {
                DisplayAlert("❌Datos Vacios", "Digite los Valores", "OK");
            }
        }

        private void rest_btn(object sender, EventArgs e)
        {
            double a = Double.Parse(num1.Text);
            double b = Double.Parse(num2.Text);
            res.Text = (a - b).ToString();
            DisplayAlert("✔ Resultado", "El Resultado es:" + res.Text, "OK");
        }
        private void mult_btn(object sender, EventArgs e)
        {
            double a = Double.Parse(num1.Text);
            double b = Double.Parse(num2.Text);
            res.Text = (a * b).ToString();
            DisplayAlert("✔ Resultado", "El Resultado es:" + res.Text, "OK");
        }
        private void div_btn(object sender, EventArgs e)
        {
            double a = Double.Parse(num1.Text);
            double b = Double.Parse(num2.Text);
            res.Text = (a / b).ToString();
            DisplayAlert("✔ Resultado", "El Resultado es:" + res.Text, "OK");
        }

        private void clear_btn(object sender, EventArgs e)
        {
            num1.Text = String.Empty;
            num2.Text = String.Empty;
            res.Text = String.Empty;
        }
    }
}
