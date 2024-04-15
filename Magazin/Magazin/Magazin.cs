using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace Magazin
{
    [Serializable]
    public class Magazin
    {
        string nume;
        int p, q;

        public string Nume { get => nume; set => nume = value; }
        public int P { get => p; set => p = value; }
        public int Q { get => q; set => q = value; }

        public Magazin()
        {
        }

        public Magazin(string nume, int p, int q)
        {
            this.nume = nume;
            this.p = p;
            this.q = q;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
