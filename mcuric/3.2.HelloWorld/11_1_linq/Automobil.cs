using System;
using System.Collections.Generic;
using System.Text;

namespace _11_1_linq
{
    public class Automobil
    {
        public Automobil(string marka, string model, int zapremina)
        {
            Marka = marka;
            Model = model;
            Zapremina = zapremina;
        }

        public string Marka { get; set; }
        public string Model { get; set; }
        public int Zapremina { get; set; }
    }
}
