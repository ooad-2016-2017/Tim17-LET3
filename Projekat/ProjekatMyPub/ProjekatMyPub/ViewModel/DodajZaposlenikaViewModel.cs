using ProjekatMyPub.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProjekatMyPub.ViewModel
{
    public class DodajZaposlenikaViewModel
    {
        public ViewModel1 parent;
        public Zaposlenik zaposleni;
        public ICommand Dodaj { get; set; }

        public ViewModel1 Parent
        {
            get
            {
                return parent;
            }

            set
            {
                parent = value;
            }
        }

        public Zaposlenik Zaposleni
        {
            get
            {
                return zaposleni;
            }

            set
            {
                zaposleni = value;
            }
        }

        public DodajZaposlenikaViewModel(ViewModel1 parent)
        {
            Parent = parent;
            zaposleni = new Zaposlenik();
            Dodaj = new RelayCommand<object>(dodaj);
        }

        public void dodaj(object parametar)
        {
            Parent.zaposlenici.Add(Zaposleni);
            Parent.navigationService.GoBack();
        }
    }
}
