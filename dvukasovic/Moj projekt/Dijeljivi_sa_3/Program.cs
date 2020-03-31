using System;

namespace Dijeljivi_sa_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dijeljivi sa 3 su:");

            for (int i = 1; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write("{0},", i);
                    
                }
            }
        }
    }
}
