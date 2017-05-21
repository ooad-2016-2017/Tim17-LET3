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
            new Zaposlenik("efazlagic1", "password", "efazlagic1@etf.unsa.ba", "Edna", "Fazlagic", new DateTime(1997,7,7), "Midhat Karic - Mitke", "060/321-1841", 3M ),
            new Musterija("kera", "password", "kerah@gmail.com", false)

        };

        public static List<Korisnik> DajSveKorisnike()
        {
            return korisnici;
        }

        public static Korisnik DajKorisnikaPoId(int id)
        {
            foreach (Korisnik p in korisnici)
            {
                if (p.Id == id)
                {
                    return p;
                }
            }


            var dialog = new MessageDialog("Ne postoji korisnik s trazenim id", "Nepostojeci id");
            return null;
        }


              private static List<Stol> stolovi = new List<Stol>()
        {
           new Stol (false),
           new Stol(false),
           new Stol(false),

        };

        public static List<Stol> DajSveStolove()
        {
            return stolovi;
        }

        public static Stol DajStolPoBroju(int brojStola)
        {
            foreach (Stol p in stolovi)
            {
                if (p.BrojStola == brojStola)
                {
                    return p;
                }

            }

            var dialog = new MessageDialog("Nepostojeci id");
            return null;
        }

            public DataSource()
        {
            Korisnik k1 = DajKorisnikaPoId(1);
            Korisnik k2 = DajKorisnikaPoId(2);
            Korisnik k3 = DajKorisnikaPoId(3);
            Stol s1 = DajStolPoBroju(1);
            Stol s2 = DajStolPoBroju(2);
            Stol s4 = DajStolPoBroju(3);
        }


    }
}
