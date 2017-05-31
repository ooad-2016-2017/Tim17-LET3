using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatMyPub.Model
{
   public class Pjesma
    {
        private String filePath;
        private String naziv;
        private String izvodjac;
        private Int32 id;
        private Int32 brojGlasova = 0;
        private static Int32 zadnjiId = 1;


        public Pjesma(String filePath, Int32 id)
        {
            FilePath = filePath;
            Naziv = naziv;
            Izvodjac = izvodjac;
            Id = zadnjiId;
            zadnjiId++;
        }

        public string FilePath { get => filePath; set => filePath = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        public string Izvodjac { get => izvodjac; set => izvodjac = value; }
        public int Id { get => id; set => id = value; }
        public int BrojGlasova { get => brojGlasova; set => brojGlasova = value; }


        
    }
}
