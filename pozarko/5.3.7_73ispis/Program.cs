using System;

namespace _5._3._7_73ispis
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 100; i++)
            {
                if (i % 7 == 0 && i % 3 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
