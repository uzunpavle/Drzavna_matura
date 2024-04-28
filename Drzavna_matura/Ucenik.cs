using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drzavna_matura
{
    public class Ucenik
    {
        public string ime, prezime, odeljenje, skola, prvi, drugi, treci;
        public Ucenik(string a, string b, string c, string d, string e, string f, string g)
        {
            ime = a;
            prezime = b;
            odeljenje = c;
            skola = d;
            prvi = e;
            drugi = f;
            treci = g;
        }
        public string ToString()
        {
            string rez = ime + "," + prezime + "," + odeljenje + "," + skola + "," + prvi + "," + drugi + "," + treci;
            return rez;
        }
        public bool Equals(Ucenik other)
        {
            if (other == null) return false;
            if (ime != other.ime) return false;
            if (prezime != other.prezime) return false;
            if (odeljenje != other.odeljenje) return false;
            if (skola != other.skola) return false;
            if (prvi != other.prvi) return false;
            if (drugi != other.drugi) return false;
            if (treci != other.treci) return false;
            return true;

        }
    }
}
