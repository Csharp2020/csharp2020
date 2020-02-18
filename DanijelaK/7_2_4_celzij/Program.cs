using System;

namespace _7_2_4_celzij
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite stupnjeve Celzijuse:");
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine("{0}C={1}F", c, Celzijus(c));
        }

        private static double Celzijus(double c)
        {
            return (double) 9 / 5 * c + 32;
        }
    }
    
}
