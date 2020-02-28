using System;
using System.Collections.Generic;
using System.Text;

namespace _8_1_3_Zaposlenik
{
    class Zaposlenik
    {
        public string ime;
        public string prezime;
        private double jmbg;
        public double brojBodova;
        public double vrijednostBoda;
        public double porez;

        public string Ime
        {
            get { return ime; }
            set { this.ime = value; }
        }

        public string Prezime
        {
            get { return prezime; }
            set { this.prezime = value; }
        }

        private double Jmbg
        {
            get { return jmbg; }
            set { this.jmbg = value; }
        }

        public double BrojBodova
        {
            get { return brojBodova; }
            set { this.brojBodova = value; }
        }

        private double VrijednostBoda
        {
            get { return vrijednostBoda; }
            set { this.vrijednostBoda = value; }
        }

        public double Porez
        {
            get {
                double neto = NetoIzracunPlace();
                if (neto < 3000) return 0.06 * neto;
                else if (neto >= 3000 && neto < 6000) return 0.12*neto;
                else { return 0.2*neto; }
            }
        }

        public Zaposlenik()
        {

        }

        public Zaposlenik(string ime, string prezime)
        {
            this.ime = ime;
            this.prezime = prezime;
        }

        public Zaposlenik(string ime, string prezime, double jmbg)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.jmbg = jmbg;
        }

        public double NetoIzracunPlace()
        {
            return this.brojBodova * this.vrijednostBoda;
        }

        public double BrutoIzracunPlace()
        {
            return this.NetoIzracunPlace() + this.Porez;
        }

    }
}
