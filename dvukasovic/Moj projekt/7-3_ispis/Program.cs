using System;

namespace _7_3_ispis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dijeljivi sa 7 a nisu sa 3");

            for (int i = 1; i <= 100; i++)
            {
                if (i % 7 == 0 && i % 3 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
