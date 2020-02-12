using System;

namespace Pr._3._2_ugnjezdeni
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite prirodan broj");
            int a = int.Parse(Console.ReadLine());
            if (a > 0)
            {
                Console.WriteLine("Unesen broj je veci od 0");
            }
            else
            {
                if (a < 0)
                {
                    Console.WriteLine("Unesen broj je manji od 0");
                }
                else
                {
                    Console.WriteLine("Uneseni broj je jednak 0");
                }
            }
        }
    }
}
