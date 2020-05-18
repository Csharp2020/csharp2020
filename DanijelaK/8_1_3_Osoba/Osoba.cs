using System;

namespace _8_1_3_Osoba
{
    internal class Osoba
    {
        private string prezime;
        private string ime;
        private DateTime datrod;

        public string Ime
        {
            get => ime;
            set => ime = Slova.PrvoVeliko(value);
        }
        public string Prezime
        {
            get => prezime;
            set => prezime = Slova.PrvoVeliko(value);
        }
        public string Datrod
        {
            get => datrod.ToString();
            set => datrod = DateTime.Parse(value);
        }
        public double BrojGodina
        {
            get
            {
                TimeSpan TS = DateTime.Now - this.datrod;
                return TS.TotalDays / 365.25;
            }


            // private set; // trebamo read only
        }

        public override string ToString()
        {
            return $"{Ime} {Prezime} naš najdraži";
        }

        internal void IspisBrojGodina()
        {
            Console.WriteLine($"Osoba {this.Ime} {this.Prezime} ima {this.BrojGodina:f1}");
        }
    }
}