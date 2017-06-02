using ProjekatMyPub.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjekatMyPub.DataSource;
using System.Windows.Input;
using ProjekatMyPub.Helper;
using ProjekatMyPub.View;
using Windows.UI.Xaml;
using Windows.UI.Popups;

namespace ProjekatMyPub.ViewModel
{
    public class ViewModel1
    {

        public List<Zaposlenik> zaposlenici;
        public String korisnikUsername;
        public String korisnikPassword;
        private String stavka1 = "Zaposlenici";
        private String stavka2 = "Narudzba";
        public List<String> stavkeMenija;
        public Korisnik korisnik;
        public String korisnikImePrezime;
        //private Zaposlenik zaposlenik;
        public INavigationService navigationService { get; set; }
        public ICommand DugmeAzuriraj { get; set; }
        public ICommand DugmeObrisi { get; set; }
        public ICommand DugmeDodaj { get; set; }
        public ICommand LogIn_Click { get; set; }
        

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

        public string KorisnikUsername
        {
            get
            {
                return korisnikUsername;
            }

            set
            {
                korisnikUsername = value;
            }
        }

        public string KorisnikPassword
        {
            get
            {
                return korisnikPassword;
            }

            set
            {
                korisnikPassword = value;
            }
        }

        public Korisnik Korisnik
        {
            get
            {
                return korisnik;
            }

            set
            {
                korisnik = value;
            }
        }

        public string KorisnikImePrezime
        {
            get
            {
                return korisnikImePrezime;
            }

            set
            {
                korisnikImePrezime = value;
            }
        }

   

        public ViewModel1()
        {
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
            navigationService = new NavigationService();
            //DugmeAzuriraj = new RelayCommand<object>(f1);
            DugmeObrisi = new RelayCommand<object>(obrisiZaposlenika);
            DugmeDodaj = new RelayCommand<object>(dodajZaposlenika);
            LogIn_Click = new RelayCommand<object>(logIn);
            
            
            KorisnikUsername = "";
            KorisnikPassword = "";

        }


        public void obrisiZaposlenika(object parameter)
        {
           
            
        }

        public void dodajZaposlenika(object parameter)
        {
            
            navigationService.Navigate(typeof(DodajZaposlenika), new DodajZaposlenikaViewModel(this));

            
        }

        

        private async void logIn(object sender)
        {
            Korisnik = DataSource.DataSource.DajKorisnikaLogIn(KorisnikUsername, KorisnikPassword);
            
            if (Korisnik != null && Korisnik is Menadzer)
            {
                KorisnikImePrezime = (Korisnik as Menadzer).Ime + " " + (Korisnik as Menadzer).Prezime;
                navigationService.Navigate(typeof(MenadzerZaposlenik), this);
            }
            else if(Korisnik != null && Korisnik is Musterija)
            {
                KorisnikImePrezime = (Korisnik as Musterija).Username;
                navigationService.Navigate(typeof(KorisnikPregledMenija), new ViewModel3(this));
            }
            else
            {
                var dialog = new MessageDialog("Pogrešno korisničko ime/šifra!", "Neuspješnaprijava");

                await dialog.ShowAsync();
            }
        }

        /*
        public string ImeMenadzera { get => imeMenadzera; set => imeMenadzera = value; }
        public string PrezimeMenadzera { get => prezimeMenadzera; set => prezimeMenadzera = value; }
        public string ImePrezimeMenadzera { get => imePrezimeMenadzera; set => imePrezimeMenadzera = value; }

        public ViewModel1()
        {

        }

        public static ViewModel1 SaPrijavljenog(Korisnik prijavljeniMenadzer)
        {
            ViewModel1 viewModel = new ViewModel1();
            viewModel.ImeMenadzera = (prijavljeniMenadzer as Menadzer).Ime;
            viewModel.PrezimeMenadzera = (prijavljeniMenadzer as Menadzer).Prezime;
            viewModel.ImePrezimeMenadzera = (prijavljeniMenadzer as Menadzer).Ime + " " + (prijavljeniMenadzer as Menadzer).Prezime;
            return viewModel;
        }
        */
    }
}
