using System;

namespace primjeroperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            mojaKlasa x; // Dekaracija x kao objekta mojaKLasa
            x = new mojaKlasa();

            Osoba o1;
            o1 = new Osoba("marko", "markovic");

            Console.WriteLine(" Osoba se zove " + o1.Ime + " a preziva " + o1.Prezime);
        }

    }

    internal class Osoba
    {
        private string v1;
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
                this.v1 = value.Substring(0, 1).ToUpper()+ value.Substring(1);
            }
        }
        public string Prezime {
            get => prezime;
            set => prezime = value.Substring(0, 1).ToUpper() + value.Substring(1);
        }
    }

    internal class mojaKlasa
    {
    }
}
