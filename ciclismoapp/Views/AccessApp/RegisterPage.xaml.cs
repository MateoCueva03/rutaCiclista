using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ciclismoapp.ViewModels;
using System.Linq;
using System.Threading.Tasks;


namespace ciclismoapp.Views.AccessApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
       
        public RegisterPage()
        {
            InitializeComponent();
            BindingContext = new Register();
        }

        private async void NavToLogin_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }

        
    }
}