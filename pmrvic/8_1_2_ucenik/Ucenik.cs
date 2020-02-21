using _8_1_3_Osoba;
using System;
using System.Collections.Generic;
using System.Text;

namespace _8_1_2_ucenik
{
    class Ucenik
    {
        private string prezime;
        private int sumaocjena;
        private int brojocjena;
        private string v1;
        private string v2;

        public Ucenik()
        {
        }

        public Ucenik(string ime, string prezime)
        {
            this.Ime = ime;
            this.prezime = prezime;
        }

        public string Ime { get;
            internal set; }
        public string Prezime {
            // get => prezime;
            set => prezime = Slova.PrvoVeliko(value);
        }
        public int OcjenaIzMatematike { get; internal set; }

        public string Ocjena {
            get {
                try
                {
                    return (this.sumaocjena / this.brojocjena).ToString();
                }
                catch (DivideByZeroException ex)
                {
                    return " nedefiniran jer ocjene nisu unesene";
                    
                }
            }
            internal set {
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
                +" Ocjena iz matematiek je "+ OcjenaIzMatematike
                + "Ukupan prosjek je "+Ocjena;
        }
    }
}
