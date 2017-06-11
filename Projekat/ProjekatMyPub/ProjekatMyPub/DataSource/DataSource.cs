using ProjekatMyPub.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;

namespace ProjekatMyPub.DataSource
{
    public class DataSource
    {

        public static ObservableCollection<Korisnik> korisnici = new ObservableCollection<Korisnik>()
        {
            new Menadzer("tvidovic1", "password", "tvidovic1@etf.unsa.ba", "Tin", "Vidovic", new DateTime(1996, 8, 6), "Splitska 10", "062/106-016", 2.5M),
            new Menadzer("tvidovic2", "password", "tvidovic1@etf.unsa.ba", "Tinky", "Winky", new DateTime(1996, 8, 6), "Splitska 10", "062/106-016", 2.5M),
            new Zaposlenik("lhasanagic1", "password", "lhasanagic1@etf.unsa.ba", "Lamija", "Hasangic", new DateTime(1996, 4, 9), "Jukiceva 11", "062/410-222", 3M),
            new Zaposlenik("efazlagic1", "password", "efazlagic1@etf.unsa.ba", "Edna", "Fazlagic", new DateTime(1997,7,7), "Midhat Karic - Mitke", "060/321-1841", 3M ),
            new Musterija("khadzibegovic1", "password", "kerah@gmail.com", false)

        };

        public static ObservableCollection<Korisnik> DajSveKorisnike()
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

        public static Korisnik DajKorisnikaLogIn(String username, String password)
        {
            foreach (Korisnik p in korisnici)
            {
                if (p.Password.Equals(password) && p.Username.Equals(username))
                {
                    return p;
                }
            }

            return null;
        }


        private static ObservableCollection<Stol> stolovi = new ObservableCollection<Stol>()
        {
           new Stol (false),
           new Stol(false),
           new Stol(false),

        };

        public static ObservableCollection<Stol> DajSveStolove()
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

        private static ObservableCollection<Pjesma> pjesme = new ObservableCollection<Pjesma>()
        {
           /*new Pjesma("pjesma1", 1),
           new Pjesma("pjesma2", 2),
           new Pjesma("pjesma3", 3),
           new Pjesma ("pjesma4", 4)*/
           new Pjesma("pjesma1","Sliver","Nirvana"),
           new Pjesma("pjesma1","Uzalud pitas","Haustor"),
           new Pjesma("pjesma1","Black","Pearl jam"),
           new Pjesma("pjesma1","Sanjam","Indeksi")
    };

        public static ObservableCollection<Pjesma> DajSvePjesme()
        {
            return pjesme;
        }

        public static Pjesma DajPjesmuPoId(int id)
        {
            foreach (Pjesma p in pjesme)
            {
                if (p.Id == id)
                {
                    return p;
                }
            }


            var dialog = new MessageDialog("Ne postoji pjesma s trazenim id", "Nepostojeci id");
            return null;
        }

        private static ObservableCollection<Playlista> playliste = new ObservableCollection<Playlista>()
        {
           new Playlista("playlista1",  pjesme),
           new Playlista("playlista2", new ObservableCollection<Pjesma>(){new Pjesma("pjesma5"), new Pjesma("pjesma6")})

        };

        public static ObservableCollection<Playlista> DajSvePlayliste()
        {
            return playliste;
        }

        public static Playlista DajPlaylistuPoNazivu(String naziv)
        {
            foreach (Playlista p in playliste)
            {
                if (p.Naziv == naziv)
                {
                    return p;
                }

            }

            var dialog = new MessageDialog("Nepostojeci naziv");
            return null;
        }

        private static ObservableCollection<Pice> pica = new ObservableCollection<Pice>()
        {
            new Pice("Coca Cola",3M,20,10,50),
            new Pice("Karlovacko",3.5M,40,10,50),
            new Pice("Paulaner",4M,70,10,50),
            new Pice("Ožujsko",3M,30,10,50)
        };

        public static ObservableCollection<Pice> DajSvaPica()
        {
            return pica;
        }

        public static Pice DajPicePoID(Int32 id)
        {
            foreach (Pice p in pica)
            {
                if (p.Id == id)
                {
                    return p;
                }
            }
            var dialog = new MessageDialog("Ne postoji pice s trazenim id", "Nepostojeci id");
            return null;
        }

        public static DataSource dajDS()
        {
            DataSource ds = new DataSource();
            return ds;
        }


        public DataSource()
        {
            Korisnik k1 = DajKorisnikaPoId(1);
            Korisnik k2 = DajKorisnikaPoId(2);
            Korisnik k3 = DajKorisnikaPoId(3);
            Stol s1 = DajStolPoBroju(1);
            Stol s2 = DajStolPoBroju(2);
            Stol s4 = DajStolPoBroju(3);
            Pjesma p1 = DajPjesmuPoId(1);
            Pjesma p2 = DajPjesmuPoId(2);
            Pjesma p3 = DajPjesmuPoId(3);
            Pjesma p4 = DajPjesmuPoId(4);
            Playlista pl1 = DajPlaylistuPoNazivu("playlista1");
            Playlista pl2 = DajPlaylistuPoNazivu("playlista2");
            Pice pice1 = DajPicePoID(1);
            Pice pice2 = DajPicePoID(2);
            Pice pice3 = DajPicePoID(3);
            Pice pice4 = DajPicePoID(4);
        }


    }
}
