using System;
using System.Collections.Generic;
using System.Text;

namespace _8_1_3_osoba
{
    class Osoba
    {
        string ime;
        public string Ime
        {
            get { return ime; }
            set { ime = FirstUpper(value); }
        }

        string prezime;
        public string Prezime
        {
            get { return prezime; }
            set { prezime = FirstUpper(value); }
        }

        DateTime dob;
        public DateTime Dob
        {
            get { return dob; }
            set { this.dob = value; }
        }

        public object Age
        {
            get { return (DateTime.Now - this.dob).Days/365.25; }
        }

        public override string ToString()
        {
            return $"{Ime} {Prezime} nas najdrazi";
        }

        internal void ShowAge()
        {
            Console.WriteLine($"Osoba {this.Ime} {this.Prezime} ima {this.Age}");
        }

        static string FirstUpper(string x)
        {
            x = x.Trim();
            return x.Substring(0, 1).ToUpper() + x.Substring(1).ToLower();
        }
    }
}
