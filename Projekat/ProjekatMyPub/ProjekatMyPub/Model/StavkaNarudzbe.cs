using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatMyPub.Model
{
    public class StavkaNarudzbe
    {
        private Pice pice;
        private Int32 kolicina;
        private Decimal cijena;

        public StavkaNarudzbe (Pice pice, Int32 kolicina)
        {
            Pice = pice;
            Kolicina = kolicina;
            Cijena = Kolicina * Pice.Cijena;
        }

        public Pice Pice { get => pice; set => pice = value; }
        public int Kolicina { get => kolicina; set => kolicina = value; }
        public decimal Cijena { get => cijena; set => cijena = value; }
    }
}
