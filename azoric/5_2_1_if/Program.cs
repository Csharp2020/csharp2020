using System;

namespace _5_2_1_if
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesiite prirodan broj");
            int a = int.Parse(Console.ReadLine());
            if (a>10)
            {
                Console.WriteLine("Unesen je broj veći od 10");

            }
            else
                Console.WriteLine("Nije veći od 10");
        }
    }
}
