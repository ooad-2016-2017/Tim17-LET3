using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatMyPub.Model
{
    public class Menadzer : Korisnik
    {
        private String ime;
        private String prezime;
        private DateTime datumRodjenja;
        private String adresa;
        private String telefon;
        private Decimal baznaPlata = 1000M;
        private Decimal koeficijent;
        private Decimal plata;

        public Menadzer(String username, String password, String email, String ime, String prezime, DateTime datumRodjenja, String adresa, String telefon, Decimal koeficijent)
            : base(username, password, email)
        {

            Ime = ime;
            Prezime = prezime;
            DatumRodjenja = datumRodjenja;
            Adresa = adresa;
            Telefon = telefon;
            Koeficijent = koeficijent;
            Plata = BaznaPlata * Koeficijent;

        }

        public string Ime
        {
            get
            {
                return ime;
            }

            set
            {
                ime = value;
            }
        }

        public string Prezime
        {
            get
            {
                return prezime;
            }

            set
            {
                prezime = value;
            }
        }

        public DateTime DatumRodjenja
        {
            get
            {
                return datumRodjenja;
            }

            set
            {
                datumRodjenja = value;
            }
        }

        public string Adresa
        {
            get
            {
                return adresa;
            }

            set
            {
                adresa = value;
            }
        }

        public string Telefon
        {
            get
            {
                return telefon;
            }

            set
            {
                telefon = value;
            }
        }

        public decimal BaznaPlata
        {
            get
            {
                return baznaPlata;
            }

            set
            {
                baznaPlata = value;
            }
        }

        public decimal Koeficijent
        {
            get
            {
                return koeficijent;
            }

            set
            {
                koeficijent = value;
            }
        }

        public decimal Plata
        {
            get
            {
                return plata;
            }

            set
            {
                plata = value;
            }
        }
    }
}
