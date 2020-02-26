using System;
using System.Collections.Generic;
using System.Text;

namespace _8._1._3_Zaposlenik
{
    class Zaposlenik
    {
        private string ime;
        private string prezime;
        private int jmbg;
        private int brojbodova;
        private int vrijednostboda;
        private double porez;

        
        public int BrojBodova
        {
            get => brojbodova;
            set => brojbodova = value;
        }
        public int VrijednostBoda
        {
            get => vrijednostboda;
            set => vrijednostboda = value;
        }
        public double Porez
        {
            get
            {
                if (NetoIzracunPlace() < 3000)
                {
                    return 0.06;
                }
                else if (NetoIzracunPlace() < 6000)
                {
                    return 0.12;
                }
                else
                {
                    return 0.2;
                }
            }
        }

        public double NetoIzracunPlace()
        {
            return BrojBodova * VrijednostBoda;
        }

        public double BrutoIzracunPlace()
        {
            return NetoIzracunPlace() + NetoIzracunPlace() * Porez;
        }

        public Zaposlenik()
        {

        }

        public Zaposlenik(string IME, string PREZIME)
        {
            ime = IME;
            prezime = PREZIME;
        }

        public Zaposlenik(string IME, string PREZIME, int JMBG)
        {
            ime = IME;
            prezime = PREZIME;
            jmbg = JMBG;
        }
    }
}
