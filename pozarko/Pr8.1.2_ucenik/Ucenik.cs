using System;
using System.Collections.Generic;
using System.Text;

namespace Pr8._1._2_ucenik
{
    class Ucenik
    {
        private string prezime;
        private int sumaocjena;
        private int brojocjena;

        public string Ime
        {
            get;
            internal set;
        }
        public string Prezime
        {
            // get => prezime;
            set => prezime = value;
        }
        public int OcjenaIzMatematike { get; internal set; }

        public string Ocjena
        {
            get
            {
                return (this.sumaocjena / this.brojocjena).ToString();
            }
            internal set
            {
                this.sumaocjena += int.Parse(value);
                this.brojocjena++;
            }
        }

        public string ispis()
        {
            return this.prezime; // unutar vlastite klase mogu vidjeti private vars
        }
        public override string ToString()
        {
            return Ime + " " + this.prezime
                + " Ocjena iz matematiek je " + OcjenaIzMatematike
                + "Ukupan prosjek je " + Ocjena;
        }
    }
}
