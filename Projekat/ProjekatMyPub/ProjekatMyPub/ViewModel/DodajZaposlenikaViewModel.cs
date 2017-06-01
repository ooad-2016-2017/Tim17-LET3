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
        public ViewModel1 Parent { get; set; }
        public Zaposlenik zaposleni;
        public ICommand Dodaj { get; set; }

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
            this.Parent = parent;
            Zaposleni = new Zaposlenik();
            Dodaj = new RelayCommand<object>(dodaj);
        }

        public void dodaj(object parametar)
        {
            Parent.Zaposlenici.Add(Zaposleni);
            
            Parent.navigationService.GoBack();
        }
    }
}
