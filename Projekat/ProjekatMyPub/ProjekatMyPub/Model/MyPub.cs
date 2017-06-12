using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatMyPub.Model
{
    public sealed class MyPub
    {
        private ObservableCollection<Korisnik> korisnici;
        private ObservableCollection<Playlista> jukebox;
        private ObservableCollection<Stol> stolovi;
        private ObservableCollection<Pice> menu;

        private MyPub()
        {
            Korisnici = new ObservableCollection<Korisnik>();
            Jukebox = new ObservableCollection<Playlista>();
            Stolovi = new ObservableCollection<Stol>();
            Menu = new ObservableCollection<Pice>();

            Korisnici = DataSource.DataSource.DajSveKorisnike();
            Jukebox = DataSource.DataSource.DajSvePlayliste();
            Stolovi = DataSource.DataSource.DajSveStolove();
            Menu = DataSource.DataSource.DajSvaPica();
        }

        private static MyPub uniqueInstance = new MyPub();

        public ObservableCollection<Korisnik> Korisnici
        {
            get
            {
                return korisnici;
            }

            set
            {
                korisnici = value;
            }
        }

        public ObservableCollection<Playlista> Jukebox
        {
            get
            {
                return jukebox;
            }

            set
            {
                jukebox = value;
            }
        }

        public ObservableCollection<Stol> Stolovi
        {
            get
            {
                return stolovi;
            }

            set
            {
                stolovi = value;
            }
        }

        public ObservableCollection<Pice> Menu
        {
            get
            {
                return menu;
            }

            set
            {
                menu = value;
            }
        }

        public static MyPub getInstance()
        {
            return uniqueInstance;
        }
    }
}
