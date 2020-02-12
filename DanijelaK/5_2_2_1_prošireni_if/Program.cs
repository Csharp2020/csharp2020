using System;

namespace _5_2_2_1_prošireni_if
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi prirodan broj");
            int a = int.Parse(Console.ReadLine());
            if (a > 0)
            {
                Console.WriteLine("Uneseni broj je veći od 0");
            }
            else if (a < 0)
            {
                Console.WriteLine("Uneseni broj je manji od 0");
            }
            else
            {
                Console.WriteLine("Uneseni broj je jednak 0");
            }

        }
    }
}
