
using ciclismoapp.Services;
using ciclismoapp.Models;



using System.Collections.ObjectModel;



namespace ciclismoapp.ViewModels
{
    internal class CiclistasViewModel:BaseViewModel
    {
        public string CompleteName { get; set; }
        public string Age { get; set; }

        public string CellPhone { get; set; }

        public string Email { get; set; }

        public string Team { get; set; }

        public string Uid { get; set; }

       

        private DBFirebase services;

        private ObservableCollection<Ciclista> _ciclistas = new ObservableCollection<Ciclista>();

        public ObservableCollection<Ciclista> Ciclistas
        {
            get { return _ciclistas; }
            set
            {
                _ciclistas = value;
                OnPropertyChanged();
            }
        }

        public CiclistasViewModel()
        {
            services = new DBFirebase();
            Ciclistas = services.getCiclistas();

        }

    }
}
