using System;

namespace _7._2._5_udaljenost
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite x1:");
            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesite y1:");
            int y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesite x2:");
            int x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesite y2:");
            int y2 = int.Parse(Console.ReadLine());

            Console.WriteLine(udaljenost(x1, y1, x2, y2));
        }

        private static double udaljenost(int x1, int y1, int x2, int y2)
        {
            double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return d;
        }
    }
}
