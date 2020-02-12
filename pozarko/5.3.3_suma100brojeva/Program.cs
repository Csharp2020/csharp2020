using System;

namespace _5._3._3_suma100brojeva
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            for (int i = 1; i <= 100; i++)
            {
                x += i;
                Console.WriteLine(x);
            }
        }
    }
}
