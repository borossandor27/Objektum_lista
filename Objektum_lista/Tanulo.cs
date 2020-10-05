using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objektum_lista
{
    class Tanulo
    {
        string nev;
        int magassag;
        bool matek;
        bool magyar;
        bool enek;
        string hobby;

        public string Nev { get => nev; }
        public int Magassag { get => magassag; set => magassag = value; }
        public bool Matek { get => matek; set => matek = value; }
        public bool Magyar { get => magyar; set => magyar = value; }
        public bool Enek { get => enek; set => enek = value; }
        public string Hobby { get => hobby; set => hobby = value; }

        public Tanulo(string nev, int magassag, bool matek, bool magyar, bool enek, string hobby)
        {
            this.nev = nev;
            this.Magassag = magassag;
            this.Matek = matek;
            Magyar = magyar;
            Enek = enek;
            Hobby = hobby;
        }

        //-- örökölt tulajdonságot felülírunk (megváltoztatunk) -> polimorfizmus
        public override string ToString()
        {
            return nev + " (" + magassag + " cm)";
        }
    }
}
