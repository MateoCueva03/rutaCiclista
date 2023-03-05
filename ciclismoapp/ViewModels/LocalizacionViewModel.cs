using System;
using System.Collections.Generic;
using System.Text;
using ciclismoapp.Models;
using ciclismoapp.Services;
using System.Collections.ObjectModel;


namespace ciclismoapp.ViewModels
{
    internal class LocalizacionViewModel : BaseViewModel
    {
        public string Hora { get; set; }
        public string Fecha { get; set; }
        public double Latitud { get; set; }
        public double Longitud { get; set; }
        public string Uid { get; set; }

        private DBFirebase services;

        private ObservableCollection<Localizacion> _localizaciones = new ObservableCollection<Localizacion>();

        public ObservableCollection<Localizacion> Localizacion
        {
            get { return _localizaciones; }
            set
            {
                _localizaciones = value;
                OnPropertyChanged();
            }
        }
        
      

        public LocalizacionViewModel(Ciclista ciclista)
        {
            services = new DBFirebase();
            Localizacion = services.getLocalizacion(ciclista);
           

        }
       



    }
}
