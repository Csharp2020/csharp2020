using System;

namespace Pr2_Operator
{
    static class ToUpperFirstLetter(this string source)
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

    class Program
    {

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            mojaKlasa x;
            x = new mojaKlasa();

            Osoba o1;
            o1 = new Osoba("marko","Markovic");
            
            //Osoba se zove  a preziva Markovic
            Console.WriteLine("Osoba se zove " + o1.Ime + " a preziva "+ o1.Prezime);
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
                //String after = before.Substring(0, 1).ToUpper() + before.String(1);
                try
                {
                    this.v1 = value.Substring(0, 1).ToUpper() + value.Substring(1);
                }
                catch(Exception ex)
                {
                    this.v1 = "";
                    //this.v1 = string.Empty; //Može i ovako

                }
                //this.v1 = value;
            }
        }
        public string Prezime {
            get => prezime;
            set => prezime = ToUpperFirstLetter(value);
        }
    }

    internal class mojaKlasa
    {
    }
}
