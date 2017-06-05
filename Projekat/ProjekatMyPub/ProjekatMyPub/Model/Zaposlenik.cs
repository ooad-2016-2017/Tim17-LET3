using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatMyPub.Model
{
    public class Zaposlenik : Korisnik, INotifyPropertyChanged

    {
        private String ime;
        private String prezime;
        private DateTime datumRodjenja;
        private String adresa;
        private String email;
        private String telefon;
        private Decimal baznaPlata = 1000M;
        private Decimal koeficjent;
        private Decimal plata;

        public Zaposlenik(String username, String password, String email, String ime, String prezime, DateTime datumRodjenja, String adresa, String telefon, Decimal koeficijent)
           : base(username, password, email)
        {
            Ime = ime;
            Prezime = prezime;
            DatumRodjenja = datumRodjenja;
            Adresa = adresa;
            Telefon = telefon;
            Koeficjent = Koeficjent;
            Plata = Koeficjent * BaznaPlata;
            Email = email;

        }

        public Zaposlenik() : base() { DatumRodjenja = new DateTime(1960, 1, 1); }

        public string Ime
        {
            get
            {
                return ime;
            }

            set
            {
                ime = value;
                OnPropertyChanged("Ime");

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
                OnPropertyChanged("Prezime");

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
                OnPropertyChanged("DatumRodjenja");


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
                OnPropertyChanged("Adresa");

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
                OnPropertyChanged("Telefon");

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

        public decimal Koeficjent
        {
            get
            {
                return koeficjent;
            }

            set
            {
                koeficjent = value;
                OnPropertyChanged("Koeficijent");

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

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
                OnPropertyChanged("Email");

            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
