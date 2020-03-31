using System;

namespace Faktorijel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Faktorijel");
            Console.WriteLine("Unesite neki broj");
            long x = int.Parse(Console.ReadLine());
            long faktorijel = 1;
            for (int i = 1; i <= x; i++)
            {
                faktorijel *= i;
            }

            Console.WriteLine("Faktorijel od {0} je {1}", x, faktorijel);
        }
    }
}
