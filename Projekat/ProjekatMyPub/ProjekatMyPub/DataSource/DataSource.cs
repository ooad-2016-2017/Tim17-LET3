using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjekatMyPub.Model;
using Windows.UI.Popups;

namespace ProjekatMyPub.DataSource
{
    public class DataSource
    {
        
        private static List<Korisnik> korisnici = new List<Korisnik>()
        {
            new Menadzer("tvidovic1", "password", "tvidovic1@etf.unsa.ba", "Tin", "Vidovic", new DateTime(1996, 8, 6), "Splitska 10", "062/106-016", 2.5M),
            new Zaposlenik("lhasanagic1", "password", "lhasanagic1@etf.unsa.ba", "Lamija", "Hasangic", new DateTime(1996, 4, 9), "Jukiceva 11", "062/410-222", 3M),
            new Zaposlenik("efazlagic1", "password", "efazlagic1@etf", "Edna", "Fazlagic", new DateTime(1997,7,7), "Midhat Karic - Mitke", "060/321-1841", 3M )

        };

        public static List<Korisnik> DajSveKorisnike()
        {
            return korisnici;
        }

        public static Korisnik DajKorisnikaPoId(int id)
        {
            foreach(Korisnik p in korisnici)
            {
                if(p.Id == id)
                {
                    return p;
                }
            }

            var dialog = new MessageDialog("Pogresno korisnicko ime/sifra!", "Neuspjesna prijava");
            return null;
        }

        public DataSource()
        {
            Korisnik k1 = DajKorisnikaPoId(1);
            Korisnik k2 = DajKorisnikaPoId(2);
            Korisnik k3 = DajKorisnikaPoId(3);
        }


    }
}
