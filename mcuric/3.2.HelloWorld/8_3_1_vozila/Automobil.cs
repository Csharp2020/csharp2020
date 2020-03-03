using System;
using System.Collections.Generic;
using System.Text;

namespace _8_3_1_vozila
{
    class Automobil:Vozilo
    {
        double ccm;

        public double Ccm { get => ccm; set => ccm = value; }

        public override string ToString()
        {
            return this.Naziv + ", " + this.Ks;
        }
    }
}
