using System;

namespace _2_2_5_primjeroperator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            mojaKlasa x; // deklaracija x kao objekta tipa mojaKlasa
            x = new mojaKlasa();

            Osoba o1;
            o1 = new Osoba("j", "");
            // Osoba se zove  a prezivaMarkovic
            Console.WriteLine("Osoba se zove" + o1.Ime + "a preziva" + o1.Prezime);

        }
    }

    internal class Osoba
    {
        private string v1; //ime
        private string prezime;

        public Osoba(string v1, string v2)
        {
            this.Ime = v1;
            this.Prezime = v2;
        }

        public string Ime
        {
            get
            {
                return this.v1;
            }
            set
            {
                try
                {
                    this.v1 = value.Substring(0, 1).ToUpper()+ value.Substring(1);
                }
                catch (Exception ex)
                {
                    this.v1 = "";
                   // this.v1 = string.Empty; //Može i ovako
                }
                //this.v1 = value;
            }
        }
        public string Prezime
        {
            get => prezime;
            set => prezime = value;
        }
    }

    internal class mojaKlasa
    {
    }
}
