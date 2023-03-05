using ciclismoapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


using System.Collections.ObjectModel;

using Firebase.Database;
using Plugin.Geolocator;
using Xamarin.Essentials;
using ciclismoapp.Models;
using ciclismoapp.Views;

using ciclismoapp.ViewModels;
using Firebase.Auth;
using Firebase.Database.Query;
using System.Xml.Linq;

namespace ciclismoapp.Views.AccessApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DeletePage : ContentPage
    {
        FirebaseClient client;
        string webAPIKey = "AIzaSyDAJwyJ0pv6OE0KMHNmbMi072x-8rPLo6c";
        FirebaseAuthProvider authProvider;
        public DeletePage()
        {
            InitializeComponent();
            BindingContext = new CiclistasViewModel();

            client = new FirebaseClient("https://valiant-monitor-343512-default-rtdb.firebaseio.com/");
            authProvider = new FirebaseAuthProvider(new FirebaseConfig(webAPIKey));

        }

        public async void LisViewName(Object sender, SelectedItemChangedEventArgs args)
        {
            await Navigation.PushAsync(new DeletePage(args.SelectedItem as Ciclista));
        }
         public async void DeleteUser(string fname, string lname, ItemTappedEventArgs args)
        {

            var ciclista = args.Item as Ciclista;

            if (ciclista == null) return;


            var toDeleteUser = (await client
                .Child("/Users")
                .OnceAsync<Ciclista>()).FirstOrDefault
                (a => a.Object.Uid == fname || a.Object.CompleteName == lname);
            await client.Child("Users").Child(toDeleteUser.Key).DeleteAsync();

            lstCiclistas.SelectedItem = null;

        }
        //public async void OnItemSelected(object sender, ItemTappedEventArgs args)
        //{
        //    var ciclista = args.Item as Ciclista;
           
        //    if (ciclista == null) return;

        //    var toDeleteUser = (await client
        //        .Child("/Users")
        //    .OnceAsync<Ciclista>()).FirstOrDefault
        //        (a => a.Object.Uid == Uid || a.Object.CompleteName == CompleteName);
        //    await client.Child("Users").Child(toDeleteUser.Key).DeleteAsync();

        //    //await Navigation.PushAsync(new CiclistaDetailsPage(ciclista));
        //    lstCiclistas.SelectedItem = null;
        //}
    }
}