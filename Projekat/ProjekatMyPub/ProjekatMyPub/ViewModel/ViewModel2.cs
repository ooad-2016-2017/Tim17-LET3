using ProjekatMyPub.Helper;
using ProjekatMyPub.Model;
using ProjekatMyPub.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProjekatMyPub.ViewModel
{

    

    class ViewModel2 
    {
        public ObservableCollection<Stol> stolovi;
        public LogInVM Parent { get; set; }
        public INavigationService navigationService { get; set; }
        private String stavka1 = "Stolovi";
        private String stavka2 = "Playliste";
        public List<String> stavkeMenija;
        public ICommand DugmeOdgovoriNaNarudzbu { get; set; }
        public ICommand DugmeDajRacun { get; set; }
        public Stol stol;
        public Pjesma Pjesma { get; set; }
        public Int32 IndeksOdabranogStola { get; set; }
        public Int32 IndeksOdabranePjesme { get; set; }
        public ObservableCollection<Playlista> Playliste { get; set; }
        public ObservableCollection<Pjesma> Pjesme { get; set; }
        public Playlista playlista;
        public ICommand DugmeAzurirajPlaylistu { get; set; }
        public ICommand DugmeKreirajPlaylistu { get; set; }
        public ICommand DugmeOdaberi { get; set; }
        public ICommand DodajPjesmu { get; set; }
        public ICommand ObrisiPjesmu { get; set; }
        public Int32 IndeksOdabranePlayliste { get; set; }


        public ViewModel2(LogInVM parent)
        {  // Obje forme
            navigationService = new NavigationService();

            StavkeMenija = new List<String>();

            StavkeMenija.Add(stavka1);

            StavkeMenija.Add(stavka2);

            Parent = parent;


            // Forma ZaposlenikStolovi

            Stolovi = new ObservableCollection<Stol>();

            Stolovi = DataSource.DataSource.DajSveStolove();

            DugmeOdgovoriNaNarudzbu = new RelayCommand<object>(odgovoriNaNarudzbu);
            DugmeDajRacun = new RelayCommand<object>(dajRacun);

            //Forma ZaposlenikPlaylista

            Playliste = new ObservableCollection<Playlista>();

            Playliste = DataSource.DataSource.DajSvePlayliste();

            DugmeAzurirajPlaylistu = new RelayCommand<object>(azurirajPlaylistu);

            DugmeKreirajPlaylistu = new RelayCommand<object>(kreirajPlaylistu);

            DugmeOdaberi = new RelayCommand<object>(odaberi);

            DodajPjesmu = new RelayCommand<object>(dodajPjesmu);

            ObrisiPjesmu = new RelayCommand<object>(obrisiPjesmu);
            Playlista = Playliste.ElementAt<Playlista>(0);

        }

        public Playlista Playlista
        {
            get { return playlista; }

            set { playlista = value; }
        }

        public ObservableCollection<Stol> Stolovi
        {
            get
            {
                return stolovi;
            }

            set
            {
                stolovi = value;
                

            }
        }

        public List<String> StavkeMenija
        {
            get
            {
                return stavkeMenija;
            }

            set
            {
                stavkeMenija = value;
            }
        }

        public Stol Stol
        {
            get
            {
                return stol;
            }

            set
            {
                stol = value;
            }
        }

        public void odgovoriNaNarudzbu(object parameter)
        {
            Stol = Stolovi.ElementAt<Stol>(IndeksOdabranogStola);
            Stol.Narudzbe.Clear();

        }

        public void dajRacun(object parameter)
        {
            Stol = Stolovi.ElementAt<Stol>(IndeksOdabranogStola);

        }

        public void azurirajPlaylistu(object parameter)
        {
            Playlista = Playliste.ElementAt<Playlista>(IndeksOdabranePlayliste);

            Pjesme = Playlista.Pjesme;
            navigationService.Navigate(typeof(AzurirajPlaylistu), this);

        }

        public void kreirajPlaylistu(object parameter)
        {
            Playlista pomocna = new Playlista("playlista", new ObservableCollection<Pjesma>());
            pomocna.Naziv += pomocna.Id.ToString();
            Playliste.Add(pomocna);
        }


        public void odaberi(object parameter)
        {
            Playlista = Playliste.ElementAt<Playlista>(IndeksOdabranePlayliste);

            Pjesme = Playlista.Pjesme;
        }

        public void dodajPjesmu(object parameter)
        {
            Pjesma = new Pjesma("filePath");

            Pjesme = Playlista.Pjesme;

            Pjesme.Add(Pjesma);

        }

        public void obrisiPjesmu(object parameter)
        {
            Pjesma = Playlista.Pjesme.ElementAt<Pjesma>(IndeksOdabranePjesme);

            Playlista.Pjesme.Remove(Pjesma);

        }

    }
}
