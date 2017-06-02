using ProjekatMyPub.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatMyPub.ViewModel
{
    public class ViewModel3
    {
        public List<String> stavkeMenija;
        private String stavka1 = "Rezervacija";
        private String stavka2 = "Meni";
        private String stavka3 = "Jukebox";
        public List<Pice> pica;
        public List<Pice> narucenaPica;
        public String imePrezimeKorisnika;
        // dodati button selectionchanged kao u VM1
        //public String passwordKorisnika;


        public List<string> StavkeMenija { get => stavkeMenija; set => stavkeMenija = value; }
        public List<Pice> Pica { get => pica; set => pica = value; }
        public string ImePrezimeKorisnika { get => imePrezimeKorisnika; set => imePrezimeKorisnika = value; }
        public List<Pice> NarucenaPica { get => narucenaPica; set => narucenaPica = value; }

        //public string PasswordKorisnika { get => passwordKorisnika; set => passwordKorisnika = value; }

        public ViewModel3(ViewModel1 parent)
        {
            StavkeMenija = new List<string>();
            StavkeMenija.Add(stavka1);
            StavkeMenija.Add(stavka2);
            StavkeMenija.Add(stavka3);
            imePrezimeKorisnika = parent.KorisnikImePrezime;
            pica = new List<Pice>();
            pica = DataSource.DataSource.DajSvaPica();
            NarucenaPica = new List<Pice>();
        }
    }
}
