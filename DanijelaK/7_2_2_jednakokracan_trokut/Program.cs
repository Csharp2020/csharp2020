using System;

namespace _7_2_2_jednakokracan_trokut
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite duljinu 1. kateta:");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Unesite duljinu 2. kateta:");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Površina jednakokračnog trokuta je {0}.", Povrsina(a,b));
        }

        private static double Povrsina(double a, double b)
        {
            return (a * b) / 2; 
        }
    }
}
