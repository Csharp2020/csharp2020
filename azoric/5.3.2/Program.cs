using System;

namespace _5._3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite broj");
            for (int i = 1; i < 100; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
