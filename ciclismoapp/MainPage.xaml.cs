using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ciclismoapp.Views.AccessApp;

namespace ciclismoapp
{
    public partial class MainPage 
    {
        public MainPage()
        {
            InitializeComponent();
            MainPage =  new NavigationPage(new RegisterPage());
        }
    }
}
