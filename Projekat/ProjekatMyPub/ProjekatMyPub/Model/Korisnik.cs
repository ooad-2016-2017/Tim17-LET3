using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatMyPub.Model
{
    abstract public class Korisnik
    {
        private String username;
        private String password;
        private String eMail;
        private Int32 id;
        private static Int32 zadnjiId = 1;

        public Korisnik(String username, String password, String email)
        {
            Username = username;
            Password = password;
            EMail = email;
            Id = zadnjiId;
            zadnjiId++;
        }

        public Korisnik()
        {
            Id = zadnjiId++;
        }
        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public string EMail
        {
            get
            {
                return eMail;
            }

            set
            {
                eMail = value;
            }
        }

        public int Id
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

        public static void vratiId()
        {
            zadnjiId--;
        }
    }
}
