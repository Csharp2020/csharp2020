using System;

namespace _9_1_1_znak_u_rijeci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi rijec i jedan znak iz rijeci");
            string rijec = Console.ReadLine();
            string znak = Console.ReadLine();
            int broj_znakova = 0;

            string r = rijec;
            while (r.IndexOf(znak) != -1)
            {
                broj_znakova++;
                r = r.Substring(r.IndexOf(znak) + 1);
            }
            Console.WriteLine($"Broj znakova {znak} u recenici je {broj_znakova}");

            // drugi nacin
            broj_znakova = 0;

            for (int i = 0; i < rijec.Length; i++)
            {
                if (rijec[i] == char.Parse(znak) )
                {
                    broj_znakova++;
                }
            }
            Console.WriteLine($"Broj znakova {znak} u recenici je {broj_znakova}");

            // treci nacin
            broj_znakova = 0;

            for (int i = 0; i < rijec.Length; i++)
            {
                if (rijec[i].ToString()== znak)
                {
                    broj_znakova++;
                }
            }
            Console.WriteLine($"Broj znakova {znak} u recenici je {broj_znakova}");


            // cetvrti nacin
            broj_znakova = 0;

            for (int i = 0; i < rijec.Length; i++)
            {
                if (rijec[i].ToString().Equals(znak))
                {
                    broj_znakova++;
                }
            }
            Console.WriteLine($"Broj znakova {znak} u recenici je {broj_znakova}");

        }
    }
}
