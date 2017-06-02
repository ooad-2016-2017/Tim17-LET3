using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatMyPub.Model
{
    public class Pice
    {
        private String naziv;
        private Decimal cijena;
        private Int32 kolicina;
        private static Int32 zadnjiID=1;
        private Int32 minimalnaKolicina;
        private Int32 kolicinaZaNabavku;
        private Int32 id;

        public string Naziv { get => naziv; set => naziv = value; }
        public decimal Cijena { get => cijena; set => cijena = value; }
        public int Kolicina { get => kolicina; set => kolicina = value; }
        public int MinimalnaKolicina { get => minimalnaKolicina; set => minimalnaKolicina = value; }
        public int KolicinaZaNabavku { get => kolicinaZaNabavku; set => kolicinaZaNabavku = value; }
        public int Id { get => id; set => id = value; }

        public Pice(String naziv, Decimal cijena, Int32 kolicina, Int32 minimalnaKolicina, Int32 kolicinaZaNabavku)
        {
            Naziv = naziv;
            Cijena = cijena;
            Kolicina = kolicina;
            MinimalnaKolicina = minimalnaKolicina;
            KolicinaZaNabavku = kolicinaZaNabavku;
            Id = zadnjiID;
            zadnjiID++;
        }
    }
}
