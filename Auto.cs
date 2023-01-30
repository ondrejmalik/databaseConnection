using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Auto
    {
        string textik;
        int cislo;

        public Auto(string textik, int cislo)
        {
            this.textik = textik;
            this.cislo = cislo;
        }
        public int Cislo { get { return cislo; } set { cislo = value; } }
        public string Textik { get { return textik; } set { textik = value; } }
    }
}
