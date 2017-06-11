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
        public Zaposlenik odabraniZaposleni;
        public Int32 indexOdabranog;
        public ObservableCollection<Pice> pica;
        public MyPubNarucivanje nabavka;
        public Nabavka stavkaNabavke;
        public Int32 indexOdabranogPica;
        public Int32 indexOdabranogPicaIzNabavke;
        public String textCijenaNabavke;
        private String stavka1 = "Zaposlenici";
        private String stavka2 = "Narudzba";
        private String stavka3 = "Log Out";
        public List<String> stavkeMenija;
        public ICommand DugmeAzuriraj { get; set; }
        public ICommand DugmeObrisi { get; set; }
        public ICommand DugmeDodaj { get; set; }
        public ICommand DodajZaposlenikaDodaj { get; set; }
        public ICommand AzurirajZaposlenikaAzuriraj { get; set; }
        public ICommand DodajZaNabavku { get; set; }
        public ICommand DodajStavku { get; set; }
        public ICommand ObrisiIzNabavke { get; set; }
        public ICommand NarudzbenicaDugme { get; set; }
        public ICommand NaruciDugme { get; set; }
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

        public Zaposlenik OdabraniZaposleni
        {
            get
            {
                return odabraniZaposleni;
            }

            set
            {
                odabraniZaposleni = value;
            }
        }

        public ObservableCollection<Pice> Pica
        {
            get
            {
                return pica;
            }

            set
            {
                pica = value;
            }
        }

        public MyPubNarucivanje Nabavka
        {
            get
            {
                return nabavka;
            }

            set
            {
                nabavka = value;
            }
        }

        public Nabavka StavkaNabavke
        {
            get
            {
                return stavkaNabavke;
            }

            set
            {
                stavkaNabavke = value;
            }
        }

        public int IndexOdabranogPica
        {
            get
            {
                return indexOdabranogPica;
            }

            set
            {
                indexOdabranogPica = value;
            }
        }

        public int IndexOdabranogPicaIzNabavke
        {
            get
            {
                return indexOdabranogPicaIzNabavke;
            }

            set
            {
                indexOdabranogPicaIzNabavke = value;
            }
        }

        public string TextCijenaNabavke
        {
            get
            {
                return textCijenaNabavke;
            }

            set
            {
                textCijenaNabavke = value;
            }
        }

        public ViewModel1(LogInVM parent)
        {

            navigationService = new NavigationService();
            zaposlenici = new ObservableCollection<Zaposlenik>();
            ObservableCollection<Korisnik> korisnici = DataSource.DataSource.DajSveKorisnike();

            foreach (Korisnik p in korisnici)
            {
                if (p is Zaposlenik)
                {
                    Zaposlenici.Add(p as Zaposlenik);
                }
            }

            Pica = new ObservableCollection<Pice>();
            Pica = DataSource.DataSource.DajSvaPica();
            StavkeMenija = new List<String>();
            StavkeMenija.Add(stavka1);
            StavkeMenija.Add(stavka2);
            StavkeMenija.Add(stavka3);

            Nabavka = new MyPubNarucivanje();

            Parent = parent;

            IndexOdabranog = -1;

            
            
            DugmeAzuriraj = new RelayCommand<object>(azurirajZaposlenika);
            DugmeObrisi = new RelayCommand<object>(obrisiZaposlenika);
            DugmeDodaj = new RelayCommand<object>(dodajZaposlenika);
            DodajZaNabavku = new RelayCommand<object>(dodajzanabavku);
            DodajZaposlenikaDodaj = new RelayCommand<object>(dodaj);
            DodajStavku = new RelayCommand<object>(dodajstavku);
            ObrisiIzNabavke = new RelayCommand<object>(obrisiiznabavke);
            NarudzbenicaDugme = new RelayCommand<object>(formirajnarudzbenicu);
            NaruciDugme = new RelayCommand<object>(naruci);
            AzurirajZaposlenikaAzuriraj = new RelayCommand<object>(azuriraj);


        }

        public void obrisiZaposlenika(object parameter)
        {
            //Zaposlenik pomocni = Zaposlenici.ElementAt<Zaposlenik>(IndexOdabranog);

            if (IndexOdabranog != -1)
            {

                Zaposlenici.RemoveAt(IndexOdabranog);
                
            }
            
        }

        public void azurirajZaposlenika(object parameter)
        {
            if (IndexOdabranog != -1)
            {
                OdabraniZaposleni = Zaposlenici.ElementAt<Zaposlenik>(IndexOdabranog);
                navigationService.Navigate(typeof(AzurirajZaposlenika), this);
            }

        }

        public void dodajZaposlenika(object parameter)
        {
            Zaposleni = new Zaposlenik();

            navigationService.Navigate(typeof(DodajZaposlenika), this);


        }

        public void dodaj(object parametar)
        {
            

            Zaposlenici.Add(Zaposleni);

            navigationService.Navigate(typeof(MenadzerZaposlenik), this);


        }

        public void azuriraj(object parametar)
        {
            
            Zaposlenici.Insert(IndexOdabranog, OdabraniZaposleni);
            Zaposlenici.RemoveAt(IndexOdabranog);
            navigationService.Navigate(typeof(MenadzerZaposlenik), this);

        }

        public void dodajzanabavku(object parametar)
        {
            StavkaNabavke = new Model.Nabavka(Pica.ElementAt<Pice>(IndexOdabranogPica), 1);
            
            navigationService.Navigate(typeof(FormaStavkaNabavke), this);
        }

        public void dodajstavku(object parametar)
        {
            Nabavka.dodajStavku(StavkaNabavke);

            navigationService.Navigate(typeof(MenadzerNarudzba), this);
        }

        public void obrisiiznabavke(object parametar)
        {
            StavkaNabavke = Nabavka.StavkeNabavke.ElementAt<Nabavka>(IndexOdabranogPicaIzNabavke);

            Nabavka.obrisiStavku(StavkaNabavke);
            
        }

        public void formirajnarudzbenicu(object parametar)
        {
            TextCijenaNabavke = "Ukupna cijena: " + Nabavka.dajCijenu().ToString();

            navigationService.Navigate(typeof(NarudzbenicaForma), this);
        }

        public void naruci(object parametar)
        {
            Nabavka.StavkeNabavke.Clear();

            navigationService.Navigate(typeof(MenadzerNarudzba), this);
        }
    }
}
