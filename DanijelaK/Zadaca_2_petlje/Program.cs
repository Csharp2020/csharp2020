using System;

namespace Zadaca_2_petlje
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Neparni do 20:");

            for (int i = 2; i <= 20; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();

            Console.WriteLine("Djeljivi s 5:");
            for (int i = 5; i <= 100; i += 5)
            {
                Console.Write("{0}," ,i);
            }
            Console.WriteLine();

            Console.WriteLine("Suma 100 brojeva");
            int suma = 0; 
            for (int i = 0; i <= 100; i++)
            {
                suma = suma + i;
            }
            Console.WriteLine("Suma prvih 100 prirodnih brojeva je {0}", suma);
            Console.WriteLine();

            // Faktorijel
            Console.WriteLine("Unesite prirodan broj (faktorijel):");
             int x= int.Parse(Console.ReadLine());
             double faktor = 1;

             for (int i = 1; i <= x; i++)
             {
                 faktor *= i;
             }
            Console.WriteLine("{0}! = {1}", x, faktor);
            Console.WriteLine();

            Console.WriteLine("Brojevi djeliljivi s 3 iz intervala [1,100]:");
            
            for (int i = 3; i <= 100; i +=3)
            {
                if (i % 3 == 0)
                {
                    Console.Write(i + ",");
                }

            }
            Console.WriteLine();
            Console.WriteLine("Prijestupne godine od 1900 do 2007.:");

            for (int i = 1900; i <= 2007; i++)
            {
                if (i % 4 == 0 && !(i % 100 == 0) || (i % 400 ==0))
                {
                    Console.Write(i + ",");
                }
            }
            Console.WriteLine();
            //Ispisi brojeve djeljive za 7 i nedjeljive sa 3 u inter. [1,100]
            Console.WriteLine("7-3 ispis:");

            for (int i = 1; i <= 100; i++)
            {
                if (i % 7 == 0 && !(i % 3 == 0))
                {
                    Console.Write("{0},", i.ToString());
                }
            }
            Console.WriteLine();
            //Koliko ima brojeva djeljivih za 7 i nedjeljivih sa 3 u inter. [1,1000]
            Console.WriteLine("7-3 koliko:");

            int kol = 0;

            for (int i = 1; i <= 1000; i++)
            {
                if (i % 7 == 0 && !(i % 3 == 0))
                {
                    kol++; 
                }
            }
            Console.WriteLine("Brojeva djelji. s 7, a nedjelj. sa 3 u intervalu [1,1000] ima {0}", kol);
            Console.WriteLine();

            //Uneseni prirodni broj ispisuje sve njegove djelitelje
            Console.WriteLine("Unesite prirodan broj (svi djelitelji):");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Djelitelji broja {0} su:", a);

            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                  Console.WriteLine("{0}", i.ToString());
                }
            }
            Console.WriteLine();

            // Savršeni broj je broj koji je jednak zbroju svih djelitelja (bez sebe samoga)
            Console.WriteLine("Unesite prirodan broj (savršen broj):");
            int b = int.Parse(Console.ReadLine());
            int zbroj = 0;

            for (int i = 1; i < b; i++)
            {
                if (b % i == 0)
                {
                    zbroj += i;
                }
            }
            if (b==zbroj)
            {
                Console.WriteLine("Broj je savršen!");
            }
            else
            {
                Console.WriteLine("Broj nije savršen!");
            }

            Console.WriteLine();

            // Savršeni brojevi iz intervala [1,1000]
            Console.WriteLine("Savršeni brojevi iz intervala [1,1000]:");
            int brojDjeli = 0;

            for (int i = 1; i <= 1000; i++)
            {
                brojDjeli = 0;
                for (int e = 1; e < i; e++)
                {
                    if (i % e == 0)
                    {
                        brojDjeli += e;
                    }
                }
                if (i== brojDjeli)
                {
                    Console.WriteLine("{0}, ", i.ToString());
                }
            }    

            Console.WriteLine();

            int min = int.MinValue;
            int max = int.MaxValue;
            int broj;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Unesite {0}. prirodan broj:", i.ToString());
                broj = int.Parse(Console.ReadLine());

                if (broj < min)
                {
                    min = broj;
                }
                if (broj > max)
                {
                    max = broj;
                }
            }

            Console.WriteLine("Najmanji = {0}, najveći = {1}", min, max);

        }
    }
}
