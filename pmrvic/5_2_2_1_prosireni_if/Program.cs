using System;

namespace _5_2_2_1_prosireni_if
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite prirodan broj");
            int a = int.Parse(Console.ReadLine());
            if (a > 0)
            {
                Console.WriteLine("Uneseni broj je veci od 0");
            }
            else if (a < 0)
            {
                Console.WriteLine("Uneseni broj je manji od 0");
            }
            else
            {
                Console.WriteLine("Uneseni broj jednak 0");
            }
        }
    }
}
