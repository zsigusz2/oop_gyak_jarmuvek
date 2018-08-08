using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_gyak
{
    class Szgk: Jarmuvek
    {
        private int ajtok;

        //Property
        public int Ajtok
        {
            get
            {
                return ajtok;
            }
            
            set
            {
                if (value<0)
                {
                    ajtok = 3;
                }
                else
                {
                    ajtok = value;
                }
            }
        }

        //Konstruktor
        public Szgk(int st, int ot, int gye, bool ef, int kob, int szem, string m, int a) : base(st, ot, gye, ef, kob, szem, m)
        {
            Ajtok = a;
        }
    }
}
