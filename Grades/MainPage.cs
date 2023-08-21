using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calificacion
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        private void btnObtenerCalificacion(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos y sean números válidos
            if (string.IsNullOrWhiteSpace(txtAsistencia.Text) ||
                string.IsNullOrWhiteSpace(txtPractica.Text) ||
                string.IsNullOrWhiteSpace(txtParcial.Text) ||
                string.IsNullOrWhiteSpace(txtFinal.Text))
            {
                // Mostrar un mensaje de error si algún campo está vacío
                DisplayAlert("Error", "Por favor, ingrese todas las notas.", "Aceptar");
                return; // Salir del evento para evitar cálculos incorrectos
            }

            // Convertir los valores ingresados en cada campo de entrada a números (asistencia, trabajoPractico, examenParcial y examenFinal)
            if (!double.TryParse(txtAsistencia.Text, out double asistencia) ||
                !double.TryParse(txtPractica.Text, out double trabajoPractico) ||
                !double.TryParse(txtParcial.Text, out double examenParcial) ||
                !double.TryParse(txtFinal.Text, out double examenFinal))
            {
                // Mostrar un mensaje de error si algún campo no es un número válido
                DisplayAlert("Error", "Por favor, ingrese números válidos en todas las notas.", "Aceptar");
                return; // Salir del evento para evitar cálculos incorrectos
            }

            // Validar que las notas no sean negativas
            if (asistencia < 0 || trabajoPractico < 0 || examenParcial < 0 || examenFinal < 0)
            {
                // Mostrar un mensaje de error si alguna nota es negativa
                DisplayAlert("Error", "Por favor, ingrese notas válidas (no negativas).", "Aceptar");
                return; // Salir del evento para evitar cálculos incorrectos
            }

            const double notaMaximaAsistencia = 10;
            const double notaMaximaTrabajoPractico = 20;
            const double notaMaximaExamenParcial = 20;
            const double notaMaximaExamenFinal = 50;

            if (asistencia > notaMaximaAsistencia || trabajoPractico > notaMaximaTrabajoPractico ||
                examenParcial > notaMaximaExamenParcial || examenFinal > notaMaximaExamenFinal)
            {
                // Mostrar un mensaje de error si alguna nota es mayor que el límite máximo
                DisplayAlert("Error", "Por favor, ingrese notas válidas (no mayores que los máximos permitidos).", "Aceptar");
                return; // Salir del evento para evitar cálculos incorrectos
            }

            // Calcular la nota final sumando las notas de asistencia, trabajoPractico, examenParcial y examenFinal
            double notaFinal = asistencia + trabajoPractico + examenParcial + examenFinal;

            // Asegurar que cada nota no sea mayor que su nota máxima permitida
            if (asistencia > notaMaximaAsistencia)
                asistencia = notaMaximaAsistencia;
            if (trabajoPractico > notaMaximaTrabajoPractico)
                trabajoPractico = notaMaximaTrabajoPractico;
            if (examenParcial > notaMaximaExamenParcial)
                examenParcial = notaMaximaExamenParcial;
            if (examenFinal > notaMaximaExamenFinal)
                examenFinal = notaMaximaExamenFinal;

            // Recalcular la nota final después de asegurarse de que cada nota esté dentro del rango permitido
            notaFinal = asistencia + trabajoPractico + examenParcial + examenFinal;

            // Asegurar que la nota final no sea mayor que 100
            if (notaFinal > 100)
                notaFinal = 100;

            // Asignar la nota final a la etiqueta correspondiente para mostrarla en la interfaz gráfica
            txtNotaFinal.Text = notaFinal.ToString();

            // Asignar la equivalencia en letra a la etiqueta correspondiente basándose en la nota final
            if (notaFinal >= 90)
                txtLetra.Text = "A";
            else if (notaFinal >= 80)
                txtLetra.Text = "B";
            else if (notaFinal >= 75)
                txtLetra.Text = "C";
            else if (notaFinal >= 70)
                txtLetra.Text = "D";
            else if (notaFinal >= 60)
                txtLetra.Text = "FE";
            else if (notaFinal >= 50)
                txtLetra.Text = "FI";
            else
                txtLetra.Text = "F";
        }

    }






}

    
