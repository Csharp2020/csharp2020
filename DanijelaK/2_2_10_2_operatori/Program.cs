using System;

namespace _2_2_10_2_operatori
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Operatori");
            int x = 2;
            x += 1; // x = x + 1 ili x++
            Console.WriteLine("X je " + x);

            x -= 7; // x = x - 7
            Console.WriteLine("X je " + x);

            x = 1;
            int y;
            y = x++; // povečaj x za 1

            Console.WriteLine("Y je " + y);

            x = 1;
            y = ++x;  // povečaj x za 1

            Console.WriteLine("Y je " + y);
        }
    }
}
