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
            private static Int32 zadnjiStol = 1;

            public Stol(Boolean daLiJeZauzet)
            {
                DaLiJeZauzet = daLiJeZauzet;
                BrojStola = zadnjiStol;
                zadnjiStol++;

            }

            public Boolean DaLiJeZauzet { get => daLiJeZauzet; set => daLiJeZauzet = value; }
            public Int32 BrojStola { get => brojStola; set => brojStola = value; }
        }
    }
}
}
