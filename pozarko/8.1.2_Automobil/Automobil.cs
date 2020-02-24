using System;
using System.Collections.Generic;
using System.Text;

namespace _8._1._2_Automobil
{
    class Automobil
    {
        private string markaautomobila;
        private double ks;
        private double osnovnacijena;



        public double KS
        {
            get => ks;
            set => ks = value;
        }

        public double OsnovnaCijena
        {
            get => osnovnacijena;
            set => osnovnacijena = value;
        }
        public string Markaautomobila { get => markaautomobila;
            set => markaautomobila = value; }

        public double IznosPoreza()
        {
            if (KS <= 50)
            {
                return 0.05*OsnovnaCijena;
            }
            else if (KS <= 150)
            {
                return 0.1*OsnovnaCijena;
            }
            else
            {
                return 0.15*OsnovnaCijena;
            }
        }
        public double UkCijena()
        {
            double x = OsnovnaCijena+IznosPoreza();
            return x;
        }
    }
}
