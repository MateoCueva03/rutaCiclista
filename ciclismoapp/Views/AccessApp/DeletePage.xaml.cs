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


namespace ciclismoapp.Views.AccessApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DeletePage : ContentPage
    {
        public DeletePage()
        {
            InitializeComponent();
            BindingContext = new CiclistasViewModel();

        }

          public async void OnItemSelected(object sender, ItemTappedEventArgs args)
        {
            var ciclista = args.Item as Ciclista;
            if (ciclista == null) return;

            await Navigation.PushAsync(new CiclistaDetailsPage(ciclista));
            lstCiclistas.SelectedItem = null;
        }

        //private async void ImageButton_Clicked(object sender, EventArgs e)
        //{
        //    await Application.Current.MainPage.DisplayAlert(
        //            "Alerta",
        //            "Enviar un correo al usuario con la razon de porque sera eliminado",
        //             "Aceptar");
        //}
    }
}