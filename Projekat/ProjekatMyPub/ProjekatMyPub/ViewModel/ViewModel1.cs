using ProjekatMyPub.Helper;
using ProjekatMyPub.Model;
using ProjekatMyPub.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Xaml.Controls;

namespace ProjekatMyPub.ViewModel
{
    class ViewModel1
    {

        public LogInVM Parent { get; set; }
        public List<Zaposlenik> zaposlenici;
        public Zaposlenik zaposleni;
        private String stavka1 = "Zaposlenici";
        private String stavka2 = "Narudzba";
        public List<String> stavkeMenija;
        public ICommand DugmeAzuriraj { get; set; }
        public ICommand DugmeObrisi { get; set; }
        public ICommand DugmeDodaj { get; set; }
        public ICommand DodajZaposlenikaDodaj { get; set; }
        public INavigationService navigationService { get; set; }

        public List<Zaposlenik> Zaposlenici
        {
            get
            {
                return zaposlenici;
            }

            set
            {
                zaposlenici = value;
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

        public ViewModel1(LogInVM parent)
        {

            navigationService = new NavigationService();
            zaposlenici = new List<Zaposlenik>();
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

            Zaposleni = new Zaposlenik();
            
            //DugmeAzuriraj = new RelayCommand<object>(f1);
            DugmeObrisi = new RelayCommand<object>(obrisiZaposlenika);
            DugmeDodaj = new RelayCommand<object>(dodajZaposlenika);

            DodajZaposlenikaDodaj = new RelayCommand<object>(dodaj);
        }

        public void obrisiZaposlenika(object parameter)
        {


        }

        public void dodajZaposlenika(object parameter)
        {

            navigationService.Navigate(typeof(DodajZaposlenika), this);


        }

        public void dodaj(object parametar)
        {
            Zaposlenici.Add(Zaposleni);

            navigationService.Navigate(typeof(MenadzerZaposlenik), this);

        }
    }
}
