﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatMyPub.Model
{
    public class Pjesma
    {
        private String filePath;
        private String naziv;
        private String izvodjac;
        private Int32 id;
        private Int32 brojGlasova = 0;
        private static Int32 zadnjiId = 1;

        public string FilePath
        {
            get
            {
                return filePath;
            }

            set
            {
                filePath = value;
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

        public string Izvodjac
        {
            get
            {
                return izvodjac;
            }

            set
            {
                izvodjac = value;
            }
        }

 

        public int BrojGlasova
        {
            get
            {
                return brojGlasova;
            }

            set
            {
                brojGlasova = value;
            }
        }

        public Pjesma(String filePath)
        {
            FilePath = filePath;
            Naziv = "";
            Izvodjac = "";
            Id = zadnjiId;
            zadnjiId++;
        }

        public Pjesma(String filePath, String imePjesme, String pjevac)
        {
            FilePath = filePath;
            Naziv = imePjesme;
            Izvodjac = pjevac;
            Id = zadnjiId;
            zadnjiId++;
        }

    }
}
