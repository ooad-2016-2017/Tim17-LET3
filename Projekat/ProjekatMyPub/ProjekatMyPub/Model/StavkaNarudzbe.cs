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

        public StavkaNarudzbe(Pice pice, Int32 kolicina)
        {
            Pice = pice;
            Kolicina = kolicina;
            Cijena = Pice.Cijena * Kolicina;
        }

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

        public Int32 Kolicina
        {
            get
            {
                return kolicina;
            }

            set
            {
                kolicina = value;
            }
        }

        public Decimal Cijena
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
    }



    
}
