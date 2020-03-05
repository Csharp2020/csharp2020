using System;
using System.Collections.Generic;

namespace _05_03_2020_AG
{
    class Program
    {
        static void Main(string[] args)
        {
            //zadatak 1
            // ispisati uneseni tekst naopako

            Console.WriteLine("Unesite tekst koji zelite da bude ispisan naopako!");
            string tekst = Console.ReadLine();
            string naopako = "";
            for(int i = tekst.Length - 1; i >=0; i--)
            {
                naopako += tekst[i];
            }
            Console.WriteLine(naopako);

            //zadatak 2
            //unos prirodnih brojeva sve dok se ne unese 0
            // ispisuje brojeve djeljive s 2 i 3
            // djeljive s 2 ali ne 3
            //djeljive s 3 ali ne s dva
            // ostali brojevi...

            int unos = 1;
            List<int> brojevi = new List<int>();
            Console.WriteLine("Unosite brojeve sve dok ne unesete 0!!");
            while(unos != 0)
            {
                try
                {
                    unos = int.Parse(Console.ReadLine());
                    brojevi.Add(unos);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Pogrešan unos, probajte ponovo!!");
                    break;
                }
            }
            brojevi.Remove(0);

            Console.WriteLine("Brojevi djeljivi sa 2 i sa 3:::");
            foreach (var item in brojevi)
            {
                if(item%2 == 0 && item%3 == 0)
                {
                    Console.Write(item + " ");
                }
            }

            Console.WriteLine("Brojevi djeljivi sa 2, ali ne i 3:::");
            foreach (var item in brojevi)
            {
                if (item % 2 == 0 && item % 3 != 0)
                {
                    Console.Write(item + " ");
                }
            }

            Console.WriteLine("Brojevi djeljivi sa 3, ali ne i 2:::");
            foreach (var item in brojevi)
            {
                if (item % 2 != 0 && item % 3 == 0)
                {
                    Console.Write(item + " ");
                }
            }

            Console.WriteLine("Ostali brojevi:::");
            foreach (var item in brojevi)
            {
                if (item % 2 != 0 && item % 3 != 0)
                {
                    Console.Write(item + " ");
                }
            }

            // zadatak 3
            //klasa ucenik

            Ucenik u1 = new Ucenik() { Ime = "Marko", Prezime = "Curic", DatumRodjenja = DateTime.Parse("10/17/1993"), Prosjek = 4 };

            Console.WriteLine(u1);

            Console.WriteLine();

            Student s1 = new Student() { Ime = "Marko", Prezime = "Curic", DatumRodjenja = DateTime.Parse("10/17/1993"), Prosjek = 4 };
            s1.Studira = "konj";
            Console.WriteLine(s1);

            Console.WriteLine();

            s1.Brak();

            Console.WriteLine(s1);



            Console.ReadLine();


        }
    }
}
