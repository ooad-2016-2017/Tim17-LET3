using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatMyPub.Model
{
    public class MyPubNarucivanje
    {
        ObservableCollection<Nabavka> stavkeNabavke;

        public ObservableCollection<Nabavka> StavkeNabavke
        {
            get
            {
                return stavkeNabavke;
            }

            set
            {
                stavkeNabavke = value;
            }
        }

        public MyPubNarucivanje()
        {
            stavkeNabavke = new ObservableCollection<Nabavka>();
        }

        public void dodajStavku(Nabavka stavkaNabavke)
        {
            StavkeNabavke.Add(stavkaNabavke);
        }
    }
}
