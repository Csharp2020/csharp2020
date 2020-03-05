using System;

namespace Trokut
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite duzinu katete a");
            double a = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesite duzinu katete b");
            double b = int.Parse(Console.ReadLine());

            Console.WriteLine("Povrsina trokuta je {0}", Povrsina(a, b));
        }

        private static double Povrsina(double a, double b)
        {
            return (a * b) / 2;
        }
    }
}
