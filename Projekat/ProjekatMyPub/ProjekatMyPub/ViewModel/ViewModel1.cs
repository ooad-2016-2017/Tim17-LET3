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

namespace ProjekatMyPub.ViewModel
{
    public class ViewModel1
    {

        public List<Zaposlenik> zaposlenici;
        //private Zaposlenik zaposlenik;
        public INavigationService navigationService { get; set; }
        public ICommand DugmeAzuriraj { get; set; }
        public ICommand DugmeObrisi { get; set; }
        public ICommand DugmeDodaj { get; set; }
        

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
            navigationService = new NavigationService();
            //DugmeAzuriraj = new RelayCommand<object>(f1);
            DugmeObrisi = new RelayCommand<object>(obrisiZaposlenika);
            DugmeDodaj = new RelayCommand<object>(dodajZaposlenika);
            
            

        }

       


        public void obrisiZaposlenika(object parameter)
        {
           
            
        }

        public void dodajZaposlenika(object parameter)
        {
            navigationService.Navigate(typeof(DodajZaposlenika), new DodajZaposlenikaViewModel(this));
            
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
