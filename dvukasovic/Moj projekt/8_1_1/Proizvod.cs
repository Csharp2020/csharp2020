using System;
using System.Collections.Generic;
using System.Text;

namespace _8_1_1
{
    class Proizvod
    {
        public string Naziv = "";
        public double Cijena =0;
        public double Marza= 0;
        public double Porez =0;

        public Proizvod(string naziv)
        {
            Naziv = naziv;
        }

        public double MPC ()
        {
            return Cijena + Marza + Porez;
        }
    }
}
