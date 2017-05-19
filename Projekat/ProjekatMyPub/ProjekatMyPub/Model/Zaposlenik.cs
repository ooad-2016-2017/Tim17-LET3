using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatMyPub.Model
{
    public class Zaposlenik : Korisnik
    {
        private String ime;
        private String prezime;
        private DateTime datumRodjena;
        private String adresa;
        private String telefon;
        private Decimal baznaPlata = 1000M;
        private Decimal koeficjent;
        private Decimal plata;

        public Zaposlenik(String username, String password, String email, String ime, String prezime, DateTime datumRodjenja, String adresa, String telefon, Decimal koeficijent)
            : base(username, password, email)
        {
            Ime = ime;
            Prezime = prezime;
            DatumRodjena = datumRodjenja;
            Adresa = adresa;
            Telefon = telefon;
            Koeficjent = koeficjent;
            Plata = Koeficjent * BaznaPlata;

        }


        public String Ime { get => ime; set => ime = value; }
        public String Prezime { get => prezime; set => prezime = value; }
        public DateTime DatumRodjena { get => datumRodjena; set => datumRodjena = value; }
        public String Adresa { get => adresa; set => adresa = value; }
        public String Telefon { get => telefon; set => telefon = value; }
        public Decimal BaznaPlata { get => baznaPlata; set => baznaPlata = value; }
        public Decimal Koeficjent { get => koeficjent; set => koeficjent = value; }
        public Decimal Plata { get => plata; set => plata = value; }
    }


}
