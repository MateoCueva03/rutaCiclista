using System;
using System.Collections.Generic;
using System.Text;
using ciclismoapp.Models

namespace ciclismoapp.ViewModels
{
    internal class DeleteCiclista
    {
        private async void DeleteMethod()
        {
            await firebaseHelper.DeletePerson(IDTxt);
            await App.Current.MainPage.Navigation.PushAsync(new ListViewPage());

        }
    }
  
}
