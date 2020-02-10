using System;

namespace _5_3_7_do_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadatak 5.3.7");
            Console.WriteLine("");
            for (int i = 1; i <= 100; i++)
            {
                if (i % 7 == 0 && !(i % 3 == 0))
                {
                    Console.WriteLine("Brojevi koji su djeljivi sa 7 a ne sa 3 su " + i);
                }
            }

            Console.WriteLine("Zadatak 5.3.8");
            Console.WriteLine("");
            int brojevi = 0;
            for (int i = 1; i < 1000; i++)
            {
                if (i % 7 == 0 && !(i % 3 == 0))
                {
                    brojevi++;
                }
            }
            Console.WriteLine("Brojeva koji su djeljivi sa 7 a ne sa 3 ima " + brojevi);

            Console.WriteLine("Zadatak 5.3.9");
            Console.WriteLine("Dijeljitelj");
            Console.WriteLine("Unesi prirodan broj");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("Dijeljitelji broja " + d + "su: ");
            for (int i = 1; i < d; i++)
            {
                if (d % i == 0)
                {
                    Console.WriteLine(i.ToString());
                }
            }


            Console.WriteLine("Zadatak 5.3.10");
            Console.WriteLine("Dijeljitelj");
            Console.WriteLine("Unesi prirodan broj");
            int c = int.Parse(Console.ReadLine());
            int dijeljitelji = 0;

            for (int i = 1; i < c; i++)
            {
                if (c % i == 0)
                {
                    dijeljitelji += i;
                }
            }

            if (c == dijeljitelji)
            {
                Console.WriteLine("Uneseni broj je savrsen");
            }
            else
            {
                Console.WriteLine("Uneseni broj nijet savrsen");
            }

            Console.WriteLine("Zadatak 5.3.14");
            Console.WriteLine("Neparni brojevi");

            for (int i = 1; i <=10; i+=2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Zadatak 5.3.15");
            Console.WriteLine("Unatrag");

            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Zadatak 5.3.16");
            Console.WriteLine("Potencije br 2 su");

            for (int i = 1; i < 1000; i*=2)
            {
                Console.WriteLine(i);
            }



        }
    }
}
