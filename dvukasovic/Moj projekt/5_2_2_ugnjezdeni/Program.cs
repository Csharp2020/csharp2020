using System;

namespace _5_2_2_ugnjezdeni
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Unesite prirodan broj");
            int a = int.Parse(Console.ReadLine());
            if (a > 0)
            {
                Console.WriteLine("Broj je veci od 0");
            }
            else
            {
                if (a < 0)
                {
                    Console.WriteLine("broj je manji od 0");
                }
                else
                {
                    Console.WriteLine("broj je jednak 0 ");
                }
                Console.WriteLine("Uneseni broj je manji od 0");
            }

        }
    }
}

