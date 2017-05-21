using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatMyPub.Model
{
   public class Musterija : Korisnik
    {
        private Boolean vip;

        public Musterija(String username, String password, String email, Boolean vip)
            : base(username, password, email)
        {
            Vip = vip;
        }

        public Boolean Vip { get => vip; set => vip = value; }
    
    }
}
