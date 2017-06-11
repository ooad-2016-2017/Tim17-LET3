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
        private ObservableCollection<Pjesma> pjesme;
        private static Int32 zadnjiId = 1;
        private Int32 id;

        public Playlista(String naziv, ObservableCollection<Pjesma> pjesme)
        {
            Naziv = naziv;
            Pjesme = pjesme;
            Id = zadnjiId++;
        }

        public Int32 Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
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
