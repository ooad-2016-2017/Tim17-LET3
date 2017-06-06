using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatMyPub.Model
{
    public class Playlista
    {
        private String naziv;
        private ObservableCollection<Pjesma> pjesme = new ObservableCollection<Pjesma>();

        public Playlista(String naziv, ObservableCollection<Pjesma> pjesme)
        {
            Naziv = naziv;
            Pjesme = pjesme;
        }

        public string Naziv
        {
            get
            {
                return naziv;
            }

            set
            {
                naziv = value;
            }
        }

        public ObservableCollection<Pjesma> Pjesme
        {
            get
            {
                return pjesme;
            }

            set
            {
                pjesme = value;
            }
        }
    }
}
