using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatMyPub.Model
{
    public class Rezervacija
    {
        private DateTime vrijeme;
        private Musterija klijent;
        private Stol stol;
        private Int32 id;
        private static Int32 zadnjiId = 1;

        public Rezervacija(DateTime vrijeme, Musterija klijent, Stol stol)
        {
            Vrijeme = vrijeme;
            Klijent = klijent;
            Stol = stol;
            Id = zadnjiId;
            zadnjiId++;
        }

        public DateTime Vrijeme { get => vrijeme; set => vrijeme = value; }
        public Musterija Klijent { get => klijent; set => klijent = value; }
        public Stol Stol { get => stol; set => stol = value; }
        public int Id { get => id; set => id = value; }
    }
}
