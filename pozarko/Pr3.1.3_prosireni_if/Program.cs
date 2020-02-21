using System;

namespace Pr3._1._3_prosireni_if
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
            else if (a < 0)
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
