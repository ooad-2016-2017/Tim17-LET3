using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatMyPub.Model
{
    public class Stol
    {
        private Boolean daLiJeZauzet;
        private Int32 brojStola;
        private String imeStola;
        private List<Narudzba> narudzbe;
        private static Int32 zadnjiStol = 1;
        private String zauzet;
        private Korisnik izvrsilaRezervaciju;

        public Stol(Boolean daLiJeZauzet)
        {
            DaLiJeZauzet = daLiJeZauzet;
            BrojStola = zadnjiStol;
            ImeStola = "Stol " + BrojStola;
            Narudzbe = new List<Narudzba>();
            zadnjiStol++;
            if (daLiJeZauzet) Zauzet = "ZAUZET";
            else Zauzet = "SLOBODAN";
        }

        public Boolean DaLiJeZauzet
        {
            get
            {
                return daLiJeZauzet;
            }

            set
            {
                daLiJeZauzet = value;
                if (value == true) Zauzet = "ZAUZET";
                else Zauzet = "SLOBODAN";
            }
        }

        public List<Narudzba> Narudzbe
        {
            get
            {
                return narudzbe;
            }

            set
            {
                narudzbe = value;
            }
        }

        public String ImeStola
        {
            get
            {
                return imeStola;
            }

            set
            {
                imeStola = value;
            }
        }

        public Int32 BrojStola
        {
            get
            {
                return brojStola;
            }

            set
            {
                brojStola = value;
            }
        }

        public String Zauzet
        {
            get
            {
                return zauzet;
            }

            set
            {
                zauzet = value;
            }
        }

        public Korisnik IzvrsilaRezervaciju
        {
            get
            {
                return izvrsilaRezervaciju;
            }
            set
            {
                izvrsilaRezervaciju = value;
            }
        }
    }
}
