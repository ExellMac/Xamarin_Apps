using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace IMCCalculator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void calculate_btn(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(height.Text) &&
                !string.IsNullOrEmpty(weight.Text))
            {
                var altura = double.Parse(height.Text);
                var peso = double.Parse(weight.Text);

                //PESO EN KILOGRAMOS Y ALTURA EN METRO.
                var imc = peso / (altura * altura);
                result.Text = imc.ToString();

                string resultado = "";

                if (imc < 16)
                {
                    resultado = "Desnutrición Servera";
                }
                else if (imc >= 16.1 && imc <= 18.4)
                {
                    resultado = "Desnutrición Moderada";
                }
                else if (imc >= 18.5 && imc <= 22)
                {
                    resultado = "Bajo Peso";
                }
                else if (imc >= 22.1 && imc < 25)
                {
                    resultado = "Peso Normal";
                }
                else if (imc >= 25 && imc <= 29.9)
                {
                    resultado = "Sobre Peso";
                }
                else if (imc >= 30 && imc <= 34.9)
                {
                    resultado = "Obesidad Tipo I";
                }
                else if (imc >= 35 && imc <= 39.9)
                {
                    resultado = "Obesidad Tipo II";
                }
                else if (imc > 40)
                {
                    resultado = "Obesidad Tipo III";
                }
                else
                {
                    resultado = "Tienes Obesidad, !Tienes que Cuidarte Mucho!";
                }

                DisplayAlert("Resultado", resultado, "OK");
            }
            else
            {
                DisplayAlert("Datos Erroneos", "Rellena los Campos", "OK");
            }
        }

        private void clear_btn(object sender, EventArgs e)
        {
            weight.Text = string.Empty;
            height.Text = string.Empty;
            result.Text = string.Empty;
        }
    }

}

