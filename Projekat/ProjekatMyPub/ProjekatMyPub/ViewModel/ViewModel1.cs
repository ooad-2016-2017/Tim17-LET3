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
using Windows.UI.Xaml.Controls;

namespace ProjekatMyPub.ViewModel
{

    

    class ViewModel1 : INotifyPropertyChanged
    {

        #region Implementacija interfejsa
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion

        

        public LogInVM Parent { get; set; }
        public ObservableCollection<Zaposlenik> zaposlenici;
        public Zaposlenik zaposleni;
        private Int32 indexOdabranog;
        private String stavka1 = "Zaposlenici";
        private String stavka2 = "Narudzba";
        public List<String> stavkeMenija;
        public ICommand DugmeAzuriraj { get; set; }
        public ICommand DugmeObrisi { get; set; }
        public ICommand DugmeDodaj { get; set; }
        public ICommand DodajZaposlenikaDodaj { get; set; }
        public INavigationService navigationService { get; set; }
        

        public ObservableCollection<Zaposlenik> Zaposlenici
        {
            get
            {
                return zaposlenici;
            }

            set
            {
                zaposlenici = value;
                OnPropertyChanged("Zaposlenici");
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

        public Zaposlenik Zaposleni
        {
            get
            {
                return zaposleni;
            }

            set
            {
                zaposleni = value;
            }
        }

        public int IndexOdabranog
        {
            get
            {
                return indexOdabranog;
            }

            set
            {
                indexOdabranog = value;

                OnPropertyChanged("IndexOdabranog");
            }
        }

        public ViewModel1(LogInVM parent)
        {

            navigationService = new NavigationService();
            zaposlenici = new ObservableCollection<Zaposlenik>();
            List<Korisnik> korisnici = DataSource.DataSource.DajSveKorisnike();

            foreach (Korisnik p in korisnici)
            {
                if (p is Zaposlenik)
                {
                    Zaposlenici.Add(p as Zaposlenik);
                }
            }
            StavkeMenija = new List<String>();
            StavkeMenija.Add(stavka1);
            StavkeMenija.Add(stavka2);

            Parent = parent;

            IndexOdabranog = -1;

            Zaposleni = new Zaposlenik();
            
            DugmeAzuriraj = new RelayCommand<object>(azurirajZaposlenika);
            DugmeObrisi = new RelayCommand<object>(obrisiZaposlenika);
            DugmeDodaj = new RelayCommand<object>(dodajZaposlenika);
            
            DodajZaposlenikaDodaj = new RelayCommand<object>(dodaj);

            
        }

        public void obrisiZaposlenika(object parameter)
        {
            //Zaposlenik pomocni = Zaposlenici.ElementAt<Zaposlenik>(IndexOdabranog);

            if (IndexOdabranog != -1)
            {
                ObservableCollection<Zaposlenik> pomocna = Zaposlenici;

                pomocna.RemoveAt(IndexOdabranog);

                Zaposlenici = pomocna;
            }
            
        }

        public void azurirajZaposlenika(object parameter)
        {

            Parent.KorisnikImePrezime = IndexOdabranog.ToString();
        }

        public void dodajZaposlenika(object parameter)
        {

            navigationService.Navigate(typeof(DodajZaposlenika), this);


        }

        public void dodaj(object parametar)
        {
            Zaposlenici.Add(Zaposleni);

            Zaposlenici = Zaposlenici;

            navigationService.Navigate(typeof(MenadzerZaposlenik), this);

            //Zaposleni = Zaposlenici.ElementAt<Zaposlenik>(2);
        }

        


    }
}
