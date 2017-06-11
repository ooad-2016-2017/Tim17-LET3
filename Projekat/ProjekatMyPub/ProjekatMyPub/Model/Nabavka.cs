using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatMyPub.Model
{
    public class Nabavka
    {

        private Pice pice;
        private Int32 kolicina;
        private Decimal cijena;

        public Pice Pice
        {
            get
            {
                return pice;
            }

            set
            {
                pice = value;
            }
        }

        public int Kolicina
        {
            get
            {
                return kolicina;
            }

            set
            {
                kolicina = value;
                cijena = kolicina * pice.Cijena;
            }
        }

        public decimal Cijena
        {
            get
            {
                return cijena;
            }

            set
            {
                cijena = value;
            }
        }

        public Nabavka(Pice pice, Int32 kolicina)
        {
            Pice = pice;
            Kolicina = kolicina;
            Cijena = kolicina * pice.Cijena;
        }
    }
}
