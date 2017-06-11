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
using Windows.UI.Xaml.Controls;

namespace ProjekatMyPub.ViewModel
{
    class ViewModel3 : INotifyPropertyChanged
    {
        public LogInVM Parent { get; set; }
        public List<String> stavkeMenija;
        private String stavka1 = "Rezervacija";
        private String stavka2 = "Meni";
        private String stavka3 = "Jukebox";
        public ObservableCollection<Pice> pica;
        public ObservableCollection<Pice> narucenaPica;
        public String imePrezimeKorisnika;
        public ObservableCollection<Pjesma> pjesme;
        public ObservableCollection<Pjesma> glasanePjesme;
        public ObservableCollection<Stol> stolovi;
        public INavigationService navigationService;
        public ICommand DugmeDodajPice_Click { get; set; }
        public ICommand DugmeNaruci_Click { get; set; }
        public ICommand DugmeRezervisiStol_Click { get; set; }
        public ICommand DugmeGlasajZaPjesmu_Click { get; set; }

        //
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public Int32 indeksOdabranogPica;
        public Pice odabranoPice;
        public Int32 indeksOdabranePjesme;
        public Pjesma odabranaPjesma;
        public Int32 indeksOdabranogStola;
        public Stol odabraniStol;
        private bool jeLiOdabrana;
        //

        public List<string> StavkeMenija
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

        public ObservableCollection<Pice> NarucenaPica
        {
            get
            {
                return narucenaPica;
            }

            set
            {
                narucenaPica = value;
                OnPropertyChanged("NarucenaPica");
            }
        }

        public string ImePrezimeKorisnika
        {
            get
            {
                return imePrezimeKorisnika;
            }

            set
            {
                imePrezimeKorisnika = value;
            }
        }

        public int IndeksOdabranogPica {
            get
            {
                return indeksOdabranogPica;
            }

            set
            {
                indeksOdabranogPica = value;
                OnPropertyChanged("IndexOdabranogPica");
            }
        }

        public Pice OdabranoPice {
            get
            {
                return odabranoPice;
            }
            set
            {
                odabranoPice = value;
                OnPropertyChanged("OdabranoPice");
            }
        }

        public int IndeksOdabranePjesme
        {
            get
            {
                return indeksOdabranePjesme;
            }

            set
            {
                indeksOdabranePjesme = value;
                OnPropertyChanged("IndexOdabranePjesme");
            }
        }

        public Pjesma OdabranaPjesma
        {
            get
            {
                return odabranaPjesma;
            }
            set
            {
                odabranaPjesma = value;
                OnPropertyChanged("OdabranaPjesma");
            }
        }

        public int IndeksOdabranogStola
        {
            get
            {
                return indeksOdabranogStola;
            }

            set
            {
                indeksOdabranogStola = value;
                OnPropertyChanged("IndexOdabranogStola");
            }
        }

        public Stol OdabraniStol
        {
            get
            {
                return odabraniStol;
            }
            set
            {
                odabraniStol = value;
                OnPropertyChanged("OdabraniStol");
            }
        }

        public ObservableCollection<Pjesma> Pjesme {
            get
            {
                return pjesme;
            }
            set
            {
                pjesme = value;
            }
        }
        public ObservableCollection<Pjesma> GlasanePjesme {
            get
            { 
                return glasanePjesme;
            }
            set
            {
                glasanePjesme = value;
            }
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

        public bool JeLiOdabrana { get => jeLiOdabrana; set => jeLiOdabrana = value; }

        public ViewModel3(LogInVM parent)
        {
            navigationService = new NavigationService();
            StavkeMenija = new List<String>();
            StavkeMenija.Add(stavka1);
            StavkeMenija.Add(stavka2);
            StavkeMenija.Add(stavka3);

            ImePrezimeKorisnika = parent.KorisnikImePrezime;
            Pica = new ObservableCollection<Pice>();
            Pica = DataSource.DataSource.DajSvaPica();
            NarucenaPica = new ObservableCollection<Pice>();

            Parent = parent;
            IndeksOdabranogPica = -1;
            IndeksOdabranePjesme = -1;
            IndeksOdabranogStola = -1;

            DugmeDodajPice_Click = new RelayCommand<object>(dodaj_stavku_narudzbe);
            DugmeNaruci_Click = new RelayCommand<object>(izvrsi_narudzbu);

            //dio koda za formu KorisnikJukebox
            Pjesme = new ObservableCollection<Pjesma>();
            GlasanePjesme = new ObservableCollection<Pjesma>();
            Pjesme = DataSource.DataSource.DajSvePjesme();

            DugmeGlasajZaPjesmu_Click = new RelayCommand<object>(glasaj);

            //dio koda za formu KorisnikRezervacija
            Stolovi = new ObservableCollection<Stol>();
            Stolovi = DataSource.DataSource.DajSveStolove();

            DugmeRezervisiStol_Click = new RelayCommand<object>(rezervisi);
        }

        public void dodaj_stavku_narudzbe(object parameter)
        {
            if (IndeksOdabranogPica != -1)
            {
                OdabranoPice = Pica.ElementAt<Pice>(IndeksOdabranogPica);
                NarucenaPica.Add(OdabranoPice);
                navigationService.Navigate(typeof(KorisnikPregledMenija), this);
            }
            
        }

        public void izvrsi_narudzbu(object parameter)
        {
            if(IndeksOdabranogStola!=-1)
            {
                OdabraniStol = Stolovi.ElementAt<Stol>(IndeksOdabranogStola);
                OdabraniStol.DaLiJeZauzet = true;
                navigationService.Navigate(typeof(KorisnikRezervacija), this);
            }
        }

        public void rezervisi(object parameter)
        {

        }

        public async void glasaj(object parameter)
        {
            if (IndeksOdabranePjesme != -1)
            {
                OdabranaPjesma = Pjesme.ElementAt<Pjesma>(IndeksOdabranePjesme);
                JeLiOdabrana = false;
                foreach (Pjesma mojaPjesma in GlasanePjesme)
                {
                    if (mojaPjesma == OdabranaPjesma)
                    {
                        var dialog = new MessageDialog("Već ste glasali za tu pjesmu.", "Neuspješno glasanje!");
                        await dialog.ShowAsync();
                        JeLiOdabrana = true;
                        break;
                    }
                }
                if (!JeLiOdabrana)
                {
                    GlasanePjesme.Add(OdabranaPjesma);
                    navigationService.Navigate(typeof(KorisnikJukebox), this);
                }
            }
        }
    }
}
