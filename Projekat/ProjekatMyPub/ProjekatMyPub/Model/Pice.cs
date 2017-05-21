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
        private Int32 minKolicina;
        private Int32 kolicinaZaNabavku;
        private Int32 id;
        private static Int32 zadnjiId;

        public Pice(String naziv, Decimal cijena, Int32 kolicina, Int32 minKolicina, Int32 kolicinaZaNabavku)
        {
            Naziv = naziv;
            Cijena = cijena;
            Kolicina = kolicina;
            MinKolicina = minKolicina;
            KolicinaZaNabavku = kolicinaZaNabavku;
            Id = zadnjiId;
            zadnjiId++;
        }

        public string Naziv { get => naziv; set => naziv = value; }
        public decimal Cijena { get => cijena; set => cijena = value; }
        public int Kolicina { get => kolicina; set => kolicina = value; }
        public int MinKolicina { get => minKolicina; set => minKolicina = value; }
        public int KolicinaZaNabavku { get => kolicinaZaNabavku; set => kolicinaZaNabavku = value; }
        public int Id { get => id; set => id = value; }
    }
}
