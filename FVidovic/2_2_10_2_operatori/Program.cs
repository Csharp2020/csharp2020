using System;

namespace _2_2_10_2_operatori
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Operatori:");
            int x = 2;
            x += 1;   // x = x + 1  ili x++
            Console.WriteLine("X je "+x);

            x -= 7;   // x = x - 7
            Console.WriteLine("X je " + x);

            x = 1;
            int y;
            y = x++;   // povećaj x za 1

            Console.WriteLine("Y je " + y);

            x = 1;
            y = ++x;   // povećaj x za 1

            Console.WriteLine("Y je " + y);

            // string s1 = (string)x;  // ivo ne radi castanjem
            string s1 = Convert.ToString(x);
            Console.WriteLine("vrijednost stringa s1 je " + s1);

        }
    }
}
