using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drzavna_matura
{
    public class Sablon
    {
        public string ime, skola, prvi, drugi, treci;
        public Sablon (string a, string b, string c, string d, string e)
        {
            ime = a;
            skola = b;
            prvi = c;                
            drugi = d;
            treci = e;
        }
    }
}
