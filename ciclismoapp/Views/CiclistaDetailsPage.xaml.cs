
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ciclismoapp.Models;
using ciclismoapp.Services;
using ciclismoapp.ViewModels;
using Xamarin.Essentials;
using Plugin.Geolocator;
using ciclismoapp.Views.AccessApp;

namespace ciclismoapp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CiclistaDetailsPage : ContentPage
    {
        DBFirebase services;
        public CiclistaDetailsPage(Ciclista ciclista)
        {
           
            InitializeComponent();
            BindingContext = new LocalizacionViewModel(ciclista);

            services = new DBFirebase();



        }

        public async void OnItemSelected(object sender, ItemTappedEventArgs args)
        {
            var localizacion = args.Item as Localizacion;
            if (localizacion == null) return;

            MapLaunchOptions options = new MapLaunchOptions { Name = "Posición actual." };
            await Map.OpenAsync(localizacion.Latitud, localizacion.Longitud, options);

            lstCiclistas.SelectedItem = null;
        }

        private async void UbicPage(object sender, EventArgs e)
        {
        

            var coor = ((Button)sender).CommandParameter;
            var coordi = coor + ";";
            string[] coordina = coordi.Split(';');
            var latitud = double.Parse(coordina[0]);
            var longitud = double.Parse(coordina[1]);

            MapLaunchOptions options = new MapLaunchOptions { Name = "Posición actual." };
            await Map.OpenAsync(latitud, longitud, options);

            //lstCiclistas.SelectedItem = null;
            //await Navigation.PushAsync(new UbicPage());
        }

        // private async void mostrarMapa(object sender, EventArgs args)
        //{
        //    var localizacion = args.Item as Localizacion;
        //    if (localizacion == null) return;

        //    MapLaunchOptions options = new MapLaunchOptions { Name = "Posición actual." };
        //    await Map.OpenAsync(localizacion.Latitud, localizacion.Longitud, options);

        //    lstCiclistas.SelectedItem = null;

        //}



    }
}