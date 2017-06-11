using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
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
            int kolicina = stavkaNabavke.Kolicina;
            foreach(Nabavka n in StavkeNabavke)
            {
                if(n.Pice.Id == stavkaNabavke.Pice.Id)
                {

                    kolicina += n.Kolicina;

                    StavkeNabavke.Remove(n);

                    break;
                    
                }
            }
            stavkaNabavke.Kolicina = kolicina;

            StavkeNabavke.Add(stavkaNabavke);
        }

        public void obrisiStavku(Nabavka stavkaNabavke)
        {
           
            foreach (Nabavka n in StavkeNabavke)
            {
                if (n.Pice.Id == stavkaNabavke.Pice.Id)
                {

                    StavkeNabavke.Remove(n);

                    return;
                }
            }
           
        }
    }
}
