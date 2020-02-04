using System;

namespace _2_2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            mojaKlasa x;
            x = new mojaKlasa();

            Osoba o1;
            o1 = new Osoba("marko", "markovic");

            Console.WriteLine("Ime: " + o1.Ime + ", Prezime: " + o1.Prezime );
            Console.ReadKey();

            //mojaKlasa.Kalkulator();

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

        public string Ime { get => v1; set => v1 = value.Substring(0, 1).ToUpper() + value.Substring(1); }
        public string Prezime { get => prezime; set => prezime = value.Substring(0,1).ToUpper() + value.Substring(1); }
    }

    internal class mojaKlasa
    {
        /*public static void Kalkulator()
        {
            int rezultat = 0;
            string unos = Console.ReadLine().ToString();
            Console.ReadKey();
            while (unos != "=") {
                rezultat += int.Parse(unos);
                unos = Console.ReadLine().ToString();
            }
            Console.WriteLine(rezultat);
            Console.ReadKey();
        }*/
    }
}
