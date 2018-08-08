using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_gyak
{
    abstract class Jarmuvek //abstract --> a main programban nem tudok belőle létrehozni példányt
    {
        //Alap értékek
        private int salyattomeg;
        private int ossztomeg;
        private int gyartas_ev;
        private bool ervenyes_forgalmi;
        private int ccm;
        private int szall_szem;
        private string marka;

        //Propertyk
        public int Salyattomeg
        {
            get
            {
                return salyattomeg;
            }

            set
            {
                if (value < 0)
                {
                    salyattomeg = 0;
                }
                else
                {
                    salyattomeg = value;
                }
            }
        }

        public int Ossztomeg
        {
            get
            {
                return ossztomeg;
            }

            set
            {
                if (value < 0)
                {
                    ossztomeg = 0;
                }
                else
                {
                    ossztomeg = value;
                }
            }
        }

        public int Gyartas_ev
        {
            get
            {
                return gyartas_ev;
            }

            set
            {
                if (value < 0)
                {
                    gyartas_ev = 0;
                }
                else
                {
                    gyartas_ev = value;
                }
            }
        }

        public bool Ervenyes_forgalmi
        {
            get
            {
                return ervenyes_forgalmi;
            }

            set
            {
                ervenyes_forgalmi = value;
            }
        }

        public int Ccm
        {
            get
            {
                return ccm;
            }

            set
            {
                if (value < 0)
                {
                    ccm = 0;
                }
                else
                {
                    ccm = value;
                }
            }
        }

        public int Szall_szem
        {
            get
            {
                return szall_szem;
            }

            set
            {
                if (value<0)
                {
                    szall_szem = 0;
                }
                else
                {
                    szall_szem = value;
                }
            }
        }

        public string Marka
        {
            get
            {
                return marka;
            }

            set
            {
                marka = value;
            }
        }

        //Konstruktor
        public Jarmuvek(int st, int ot, int gye, bool ef, int kob, int szem, string m)
        {
            Salyattomeg = st;
            Ossztomeg = ot;
            Gyartas_ev = gye;
            Ervenyes_forgalmi = ef;
            Ccm = kob;
            Szall_szem = szem;
            Marka = m;
        }
    }
}
