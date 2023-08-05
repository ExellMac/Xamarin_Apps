using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using Xamd.ImageCarousel.Forms.Plugin.Abstractions;


namespace GaleriaImagenes
{
    public partial class MainPage : ContentPage
    {

        ObservableCollection<FileImageSource> imageSpaceSources = new ObservableCollection<FileImageSource>();

        public MainPage()
        {
            InitializeComponent();

            imageSpaceSources.Add("planetas");
            imageSpaceSources.Add("Satelite");
            imageSpaceSources.Add("Asteroide");
            imageSpaceSources.Add("Estrellas");
            imageSpaceSources.Add("Galaxia");
            imageSpaceSources.Add("BlackHole");
            imageSpaceSources.Add("Gigachad_galactico");

            spaceSlider.Images = imageSpaceSources;

        }

        async void wikipedia_btn(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Wikipedia());
        }

        async void nasa_btn(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Nasa());
        }

        async void youtube_btn(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Youtube());
        }

        async void gigachad_btn(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GigaChad());
        }


    }
}
