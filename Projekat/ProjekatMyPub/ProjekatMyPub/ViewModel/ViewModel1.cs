using ProjekatMyPub.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjekatMyPub.DataSource;
using System.Windows.Input;
using ProjekatMyPub.Helper;

namespace ProjekatMyPub.ViewModel
{
    public class ViewModel1
    {

        public List<Zaposlenik> zaposlenici = new List<Zaposlenik>();
        //private Zaposlenik zaposlenik;
        public INavigationService navigationService { get; set; }
        public ICommand DugmeAzuriraj { get; set; }
        public ICommand DugmeObrisi { get; set; }
        public ICommand DugmeDodaj { get; set; }
        public List<Zaposlenik> Zaposlenici { get => zaposlenici; set => zaposlenici = value; }

        public ViewModel1()
        {
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
            //DugmeDodaj = new RelayCommand<object>(f3);

        }
        //private String prezimeMenadzera;
        //private String imePrezimeMenadzera;

        public void obrisiZaposlenika(object parameter)
        {
           
            
        }
        //public Zaposlenik Zaposlenik { get => zaposlenik; set => zaposlenik = value; }
        

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
