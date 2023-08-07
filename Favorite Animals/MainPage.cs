using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace AnimalesFavoritos
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();


        }

        private void pAleman_btn(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://www.expertoanimal.com/razas-de-perros/pastor-aleman.html", BrowserLaunchMode.SystemPreferred);
        }

        private void rottweiler_btn(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://www.expertoanimal.com/razas-de-perros/rottweiler.html", BrowserLaunchMode.SystemPreferred);
        }

        private void Golden_btn(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://www.expertoanimal.com/razas-de-perros/golden-retriever-o-cobrador-dorado.html", BrowserLaunchMode.SystemPreferred);
        }

        private void doberman_btn(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://www.expertoanimal.com/razas-de-perros/doberman-pinscher.html", BrowserLaunchMode.SystemPreferred);
        }

        private void pitbull_btn(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://www.expertoanimal.com/razas-de-perros/pit-bull-terrier-americano.html", BrowserLaunchMode.SystemPreferred);
        }

    }
}
