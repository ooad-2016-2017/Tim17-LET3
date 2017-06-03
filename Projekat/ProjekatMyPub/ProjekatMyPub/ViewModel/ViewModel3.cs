using ProjekatMyPub.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatMyPub.ViewModel
{
    class ViewModel3
    {
        public List<String> stavkeMenija;
        private String stavka1 = "Rezervacija";
        private String stavka2 = "Meni";
        private String stavka3 = "Jukebox";
        public List<Pice> pica;
        public List<Pice> narucenaPica;
        public String imePrezimeKorisnika;

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

        public List<Pice> Pica
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

        public List<Pice> NarucenaPica
        {
            get
            {
                return narucenaPica;
            }

            set
            {
                narucenaPica = value;
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

        // dodati button selectionchanged kao u VM1
        //public String passwordKorisnika;




        //public string PasswordKorisnika { get => passwordKorisnika; set => passwordKorisnika = value; }

        public ViewModel3(LogInVM parent)
        {
            StavkeMenija = new List<string>();
            StavkeMenija.Add(stavka1);
            StavkeMenija.Add(stavka2);
            StavkeMenija.Add(stavka3);
            ImePrezimeKorisnika = parent.KorisnikImePrezime;
            Pica = new List<Pice>();
            Pica = DataSource.DataSource.DajSvaPica();
            NarucenaPica = new List<Pice>();
        }
    }
}
