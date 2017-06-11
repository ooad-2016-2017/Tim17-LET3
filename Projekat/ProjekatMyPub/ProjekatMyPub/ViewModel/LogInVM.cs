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
using Windows.UI.Popups;

namespace ProjekatMyPub.ViewModel
{
    class LogInVM : INotifyPropertyChanged
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

        public Korisnik korisnik;
        public Musterija musterija;
        public String potvrdaPassworda;
        public ICommand LogIn_Click { get; set; }
        public ICommand RegistrujSe_Click { get; set; }
        public ICommand NemateRacun_Click { get; set; }
        public ObservableCollection<Korisnik> korisnici;
        public String korisnikImePrezime;
        public String korisnikUsername;
        public String korisnikPassword;
        public INavigationService navigationService { get; set; }

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

        public String PotvrdaPassworda
        {
            get
            {
                return potvrdaPassworda;
            }

            set
            {
                potvrdaPassworda = value;
            }
        }


        public ObservableCollection<Korisnik> Korisnici
        {
            get
            {
                return korisnici;
            }

            set
            {
                korisnici = value;
            }
        }


        public Musterija Musterija
        {
            get
            {
                return musterija;
            }

            set
            {
                musterija = value;
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

                OnPropertyChanged("KorisnikImePrezime");

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

        public LogInVM()
        {
            LogIn_Click = new RelayCommand<object>(logIn);
            RegistrujSe_Click = new RelayCommand<object>(registrujSe);
            NemateRacun_Click = new RelayCommand<object>(nemateRacun);
            navigationService = new NavigationService();
            korisnici = new ObservableCollection<Korisnik>();
            korisnici = DataSource.DataSource.DajSveKorisnike();

        }


        private async void logIn(object sender)
        {
            Korisnik = DataSource.DataSource.DajKorisnikaLogIn(KorisnikUsername, KorisnikPassword);

            if (Korisnik != null && Korisnik is Menadzer)
            {
                KorisnikImePrezime = (Korisnik as Menadzer).Ime + " " + (Korisnik as Menadzer).Prezime;
                navigationService.Navigate(typeof(MenadzerZaposlenik), new ViewModel1(this) );
            }
            else if (Korisnik != null && Korisnik is Musterija)
            {
                KorisnikImePrezime = (Korisnik as Musterija).Username;
                navigationService.Navigate(typeof(KorisnikPregledMenija), new ViewModel3(this));
            }
            /*
            else if (Korisnik != null && Korisnik is Zaposlenik)
            {
                KorisnikImePrezime = (Korisnik as Zaposlenik).Ime + " " + (Korisnik as Zaposlenik).Prezime;
                navigationService.Navigate(typeof(ZaposlenikStolovi), new ViewModel2(this));
            }
            */
            else
            {
                var dialog = new MessageDialog("Pogrešno korisničko ime/šifra!", "Neuspješnaprijava");

                await dialog.ShowAsync();
            }
        }

        private void nemateRacun(object sender)
        {
            Musterija = new Musterija();

            navigationService.Navigate(typeof(Registracija), this);

        }

        private async void registrujSe(object sender)
        {
            

            if (PotvrdaPassworda == Musterija.Password)
            {
                korisnici.Add(Musterija);
                navigationService.Navigate(typeof(Login));

            }

            else
            {
                var dialog = new MessageDialog("Ponovo potvrdite odabrani password!");

                await dialog.ShowAsync();
            }
        }
    }
}
