using System;
using System.Collections.Generic;
using System.Text;

namespace _05_03_2020_AG
{
    class Ucenik : IUcenik
    {
        string ime;
        public string Ime { get; set; }
        string prezime;
        public string Prezime { get; set; }
        private DateTime datumrodjenja;
        public DateTime DatumRodjenja { get; set; }
        private double prosjek;
        public double Prosjek { get; set; }

        public int Starost()
        {
            return (int)(((DateTime.Now - this.datumrodjenja).Days) / 365.25);
        }
        public void ProsjekRijecima()
        {
            switch (this.Prosjek)
            {
                case 1: Console.Write("Nedovoljan!");
                        break;
                case 2: Console.Write("Doovoljan!");
                        break;
                case 3: Console.Write("Dobar!");
                        break;
                case 4: Console.Write("Vrlo dobar");
                        break;
                case 5: Console.Write("Odličan");
                        break;
                default: Console.WriteLine("Pogrešan prosjek, negdje ste nešto krivo unijeli, provjerite pa probajte ponovo!!");
                        break;
            }
        }

        public override string ToString()
        {
            return "Ucenik " + Ime + " " + Prezime + " rodjen " + DatumRodjenja + " ovu akademsku godinu zavrsio je s prosjekom: " + Prosjek;
        }
    }
}
