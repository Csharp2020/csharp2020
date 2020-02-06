using System;

namespace _5_2_1_naredba_if
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite prirodan broj");
            int a = int.Parse(Console.ReadLine());
            if (a>10)
            {
                Console.WriteLine("Uneseni broj je veći od 10");
            }
            else
            {
                Console.WriteLine("Uneseni broj nije veći od 10");
            }
        }
    }
}
