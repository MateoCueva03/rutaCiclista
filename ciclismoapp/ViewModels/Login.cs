using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Firebase.Auth;
using GalaSoft.MvvmLight.Command;
using Newtonsoft.Json;
using Xamarin.Essentials;
using Xamarin.Forms;
using ciclismoapp.Views.AccessApp;

namespace ciclismoapp.ViewModels
{
    internal class Login : BaseViewModel
    {
        #region Attribute
        public string email;
        public string password;
        public bool isRunning;
        public bool isVisible;
        public bool isEnabled;
        #endregion
        public static FirebaseAuthLink auth;
        #region Properties
        public string EmailTxt
        {
            get { return this.email; }
            set { SetValue(ref this.email, value); }
        }

        public string PasswordTxt
        {
            get { return this.password; }
            set { SetValue(ref this.password, value); }
        }

        public bool IsRunningTxt
        {
            get { return this.isRunning; }
            set { SetValue(ref this.isRunning, value); }
        }


        public bool IsVisibleTxt
        {
            get { return this.isVisible; }
            set { SetValue(ref this.isVisible, value); }
        }

        public bool IsEnabledTxt
        {
            get { return this.isEnabled; }
            set { SetValue(ref this.isEnabled, value); }
        }

        #endregion

        #region Commands
        public ICommand LoginCommand
        {
            get
            {
                return new RelayCommand(LoginMethod);
            }
        }
        #endregion

        #region Methods


        public async void LoginMethod()
        {
            if (string.IsNullOrEmpty(this.email))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "El campo correo electrónico no puede estar vacío.",
                    "Aceptar");
                return;
            }
            if (string.IsNullOrEmpty(this.password))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "El campo contraseña no puede estar vacío.",
                    "Aceptar");
                return;
            }

            string WebAPIkey = "AIzaSyDAJwyJ0pv6OE0KMHNmbMi072x-8rPLo6c";


            var authProvider = new FirebaseAuthProvider(new FirebaseConfig(WebAPIkey));
            try
            {
                auth = await authProvider.SignInWithEmailAndPasswordAsync(EmailTxt.ToString(), PasswordTxt.ToString());
                var content = await auth.GetFreshAuthAsync();
                var serializedcontnet = JsonConvert.SerializeObject(content);

                Preferences.Set("MyFirebaseRefreshToken", serializedcontnet);

                /*await Application.Current.MainPage.DisplayAlert(
                   "Info",
                   "Sesión iniciada con Firebase.",
                   "Aceptar");*/
                Console.WriteLine("estado de veriicacion de correo:       " + content.User.IsEmailVerified);
               if (content.User.IsEmailVerified == false)
                {
                    await Application.Current.MainPage.Navigation.PushAsync(new LocalizationPage());


                }
                else
                {
                    await Application.Current.MainPage.Navigation.PushAsync(new LocalizationPage());


                }


            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Alert", "El correo o la contraseña no son correctos.", "Aceptar");
            }

            this.IsVisibleTxt = true;
            this.IsRunningTxt = true;
            this.IsEnabledTxt = false;

            await Task.Delay(20);

            

            this.IsRunningTxt = false;
            this.IsVisibleTxt = false;
            this.IsEnabledTxt = true;

        }

       

        #endregion

        #region Constructor
        public Login()
        {
            this.IsEnabledTxt = true;
        }
        #endregion
    }
}
