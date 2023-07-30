using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Plugin.Geolocator;
using Xamarin.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace GPS
{
    public partial class MainPage : ContentPage
    {

        double longitud;
        double latitud;

        public MainPage()
        {
            InitializeComponent();
            activeGPS();
        }

        
        private async void btnAbrir_Clicked(object sender, EventArgs e)
        {
            if (!double.TryParse(inputLat.Text, out double latt))
                return; // Intenta convertir el texto en txtLatitud a un valor double (latitud). Si la conversión falla, se sale del método.
            if (!double.TryParse(inputLong.Text, out double lng))
                return; // Intenta convertir el texto en txtLongitud a un valor double (longitud). Si la conversión falla, se sale del método.
          
            await Map.OpenAsync(latt, lng, new MapLaunchOptions
            {
                Name = "Coordenadas", // Establece el nombre de ubicación con el texto contenido en txtNombreUbicacion.
                NavigationMode = NavigationMode.None // Establece el modo de navegación a None.
            });
        }

        private async void activeGPS()
        {
            var geolocator = CrossGeolocator.Current;

            geolocator.DesiredAccuracy = 50;

            if (geolocator.IsGeolocationEnabled)
            {
                if (!geolocator.IsListening)
                {
                    await geolocator.StartListeningAsync(TimeSpan.FromSeconds(1), 5);

                }

                geolocator.PositionChanged += (cambio, args) =>
                {
                    var loc = args.Position;
                    Long.Text = loc.Longitude.ToString();
                    longitud = double.Parse(Long.Text);
                    Lat.Text = loc.Latitude.ToString();
                    latitud = double.Parse(Lat.Text);



                };
            }

        }

        private async void mostrarUbicacion(object sender, EventArgs e)
        {
            MapLaunchOptions options = new MapLaunchOptions { Name = "Mi Posicion Actual" };

            await Map.OpenAsync(latitud, longitud, options);

        }



    }


    
        
}
