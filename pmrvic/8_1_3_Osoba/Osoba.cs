using System;

namespace _8_1_3_Osoba
{
    internal class Osoba
    {
        private string prezime;
        private string ime;
        private DateTime datrod;

        public string Ime {
            get => ime;
            set => ime = Slova.PrvoVeliko(value);
    }
        public string Prezime {
            get => prezime;
            set => prezime = Slova.PrvoVeliko(value);
        }
        public string Datrod
        {
            get => datrod.ToString();
            set => datrod = DateTime.Parse(value);

        }
        public object BrojGodina {
            get =>  DateTime.Now - this.datrod;
             
                 }

        public override string ToString()
        {
            return $"{Ime} {Prezime} naš najdraži";
        }

        internal void IspisBrojGodina()
        {
            Console.WriteLine($"Osoba {this.Ime} {this.Prezime} ima {this.BrojGodina}");
        }
    }
}