using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatMyPub.Model
{
    public class Narudzba
    {
        private static Int32 zadnjiBrojNarudzbe = 1;
        private Int32 brojNarudzbe;
        private Decimal cijena;
        private List<StavkaNarudzbe> stavkeNarudzbe;

        public Narudzba()
        {
            BrojNarudzbe = zadnjiBrojNarudzbe;
            Cijena = 0M;
            zadnjiBrojNarudzbe++;
            StavkeNarudzbe = new List<StavkaNarudzbe>();  
        }

        public Int32 BrojNarudzbe
        {
            get
            {
                return brojNarudzbe;
            }

            set
            {
                brojNarudzbe = value;
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

        public List<StavkaNarudzbe> StavkeNarudzbe
        {
            get
            {
                return stavkeNarudzbe;
            }

            set
            {
                stavkeNarudzbe = value;
            }
        }

    }
}
