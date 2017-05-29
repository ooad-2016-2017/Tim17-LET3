using ProjekatMyPub.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatMyPub.ViewModel
{
    public class ViewModel1
    {

        private String imeMenadzera;
        private String prezimeMenadzera;
        private String imePrezimeMenadzera;

        public string ImeMenadzera { get => imeMenadzera; set => imeMenadzera = value; }
        public string PrezimeMenadzera { get => prezimeMenadzera; set => prezimeMenadzera = value; }
        public string ImePrezimeMenadzera { get => imePrezimeMenadzera; set => imePrezimeMenadzera = value; }

        public ViewModel1()
        {

        }

        public static ViewModel1 SaPrijavljenog(Korisnik prijavljeniMenadzer)
        {
            ViewModel1 viewModel = new ViewModel1();
            viewModel.ImeMenadzera = (prijavljeniMenadzer as Menadzer).Ime;
            viewModel.PrezimeMenadzera = (prijavljeniMenadzer as Menadzer).Prezime;
            viewModel.ImePrezimeMenadzera = (prijavljeniMenadzer as Menadzer).Ime + " " + (prijavljeniMenadzer as Menadzer).Prezime;
            return viewModel;
        }
    }
}
