using System;

namespace Djeljivi_sa_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Djeljivi sa 5");

            for (int i = 0; i < 100; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine("Broj {0} je dijeljiv sa 5", i);
                }
            }

        }
    }
}
