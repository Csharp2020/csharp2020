using System;

namespace _2_2_5_primjeroperator
{
    static class ToUp
    {
        public static string ToUpperFirstLetter(this string source)
        {
            if (string.IsNullOrEmpty(source))
                return string.Empty;
            // convert to char array of the string
            char[] letters = source.ToCharArray();
            // upper case the first char
            letters[0] = char.ToUpper(letters[0]);
            // return the array made of the new char array
            return new string(letters);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            mojaKlasa x;  // deklaracija x kao objekta tipa mojaKlasa
            x = new mojaKlasa();

            Osoba o1;
            o1 = new Osoba("Marko", "marković");

            Osoba o2 = new Osoba("Marko", "marković");

    

            // Osoba se zove  a prezivaMarkovic
            Console.WriteLine("Osoba se zove " + o1.Ime + " a preziva " + o1.Prezime);

            if (o2 == o1)
            {
                Console.WriteLine("Osobe su iste! Yessss!");
            }
            else
            {
                Console.WriteLine("Nemoš vjerovat, ali nisu iste!");
            }

        }

    }

    internal class Osoba
    {
        private string v1;  //ime
        private string prezime;

        public Osoba(string v1, string v2)
        {
            this.Ime = v1;
            this.Prezime = v2;
        }

        public string Ime {
            get
            {
                return this.v1;
            }
            set
            {
                // String after = before.Substring(0, 1).ToUpper() + before.Substring(1);
                try
                {
                this.v1 = value.Substring(0, 1).ToUpper()+ value.Substring(1);
                }
                catch (Exception ex)  //System.ArgumentOutOfRangeException
                {
                    this.v1 = "Joe";
                  //  this.v1 = string.Empty;  // Može i ovako
                }
                
                //this.v1 = value;
            }
        }
        public string Prezime {
            get => prezime;
            set => prezime = ToUp.ToUpperFirstLetter(value);
        }
    }

    internal class mojaKlasa
    {
    }
}
