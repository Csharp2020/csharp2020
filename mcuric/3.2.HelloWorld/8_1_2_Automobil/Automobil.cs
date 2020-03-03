using System;
using System.Collections.Generic;
using System.Text;

namespace _8_1_2_Automobil
{
    class Automobil
    {
        public string MarkaAutomobila;
        public double KS;
        public double OsnovnaCijena;

        public double IznosPoreza()
        {
            if (KS < 50)
            {
                return 0.05;
            }
            else if (KS > 50 && KS < 150)
            {
                return 0.1;
            }
            else
            {
                return 0.15;
            }
        }
    }
}
