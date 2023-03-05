

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using Plugin.Geolocator;
using System;
using Firebase.Database;
using Firebase.Database.Query;
using Firebase.Auth;
using ciclismoapp.ViewModels;
using Firebase.Database;
using System.Collections.ObjectModel;
using ciclismoapp.Models;

using System.Linq;
using ciclismoapp.Models;



namespace ciclismoapp.Views.AccessApp
{
    public partial class UbicPage : ContentPage
    {
        double lati;
        double longi;
        private FirebaseAuth mAuth;
        public bool fin = false;

        FirebaseClient firebaseCliente = new FirebaseClient("https://valiant-monitor-343512-default-rtdb.firebaseio.com/");

        string WebAPIkey = "AIzaSyDAJwyJ0pv6OE0KMHNmbMi072x-8rPLo6c";



        public UbicPage()
        {
            InitializeComponent();
            Localizar();
        }

        private async void Localizar()
        {
            var locator = CrossGeolocator.Current;
            locator.DesiredAccuracy = 50;

            var localAuth = Login.auth;
            var user = localAuth.User.LocalId;


            if (locator.IsGeolocationAvailable)
            {
                if(locator.IsGeolocationEnabled)
                {
                    if(!locator.IsListening)
                    {
                        await locator.StartListeningAsync(TimeSpan.FromSeconds(1), 5);
                    }
                    locator.PositionChanged += (cambio, args) =>
                    {
                        var loc = args.Position;
                        LongitudTxt.Text = loc.Longitude.ToString();
                        longi = double.Parse(LongitudTxt.Text);
                        LatitudTxt.Text = loc.Latitude.ToString();
                        lati = double.Parse(LatitudTxt.Text);

                        
                    };
                    
                }
                

               System.Threading.Thread.Sleep(1000);

                
                    await firebaseCliente
                        .Child("/Cyclists")
                        .Child(user)
                        .Child("Localization")
                        .PostAsync(new { longitud = longi, latitud = lati, fecha = DateTime.Now.ToString("dd/MM/yyyy"), hora = DateTime.Now.ToString("hh:mm:ss tt") });
                
            }

           while (fin== false)
            {
                
                await firebaseCliente
                      .Child("/Cyclists")
                      .Child(user)
                      .Child("Localization")
                      .PostAsync(new { longitud = longi, latitud = lati, fecha = DateTime.Now.ToString("dd/MM/yyyy"), hora = DateTime.Now.ToString("hh:mm:ss tt"), uid = user });


                
                System.Threading.Thread.Sleep(5000);


            }

            




        }

        private async void mostrarMapi(object sender, EventArgs args1)
        {

            MapLaunchOptions options = new MapLaunchOptions { Name = "Posición actual." };
            await Map.OpenAsync(lati, longi, options);

        }
    }

   
}