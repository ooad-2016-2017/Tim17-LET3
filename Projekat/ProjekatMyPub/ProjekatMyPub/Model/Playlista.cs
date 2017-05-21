using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatMyPub.Model
{
   public class Playlista
    {
        private String naziv;
        private List<Pjesma> pjesme;

        public Playlista(String naziv, List<Pjesma> pjesme)
        {
            Naziv = naziv;
            Pjesme = pjesme;
        }

        public string Naziv { get => naziv; set => naziv = value; }
        public List<Pjesma> Pjesme { get => pjesme; set => pjesme = value; }
  
    }
}
