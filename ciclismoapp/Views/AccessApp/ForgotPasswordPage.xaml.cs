using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Firebase.Auth;
using ciclismoapp.Services;
namespace ciclismoapp.Views.AccessApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ForgotPasswordPage : ContentPage
    {

        DBFirebase services;

        public ForgotPasswordPage()
        {
            InitializeComponent();
            services = new DBFirebase();

        }

        private async void ButtonSendLink_Clicked(object sender, EventArgs e)
        {
            string email = TxtEmail.Text;
            Console.WriteLine("el correo es..........." + email);
            if (string.IsNullOrEmpty(email))
            {
                await DisplayAlert("Advertencia", "Por favor complete el campo solicitado.", "Aceptar");
                return;
            }

            bool isSend = await services.ResetPassword(email);

            Console.WriteLine("el correo es..........." + isSend);

            if (isSend)
            {
                await DisplayAlert("Resetear Contraseña", "El enlace para el cambio de contraseña ha sido enviado a su correo electrónico.", "Aceptar");
                
            }
            else
            {
                await DisplayAlert("Resetear Contraseña", "Ocurrió un error al enviar el enlace de recuperación.", "Ok");
            }
        }



    }
}