using System;

namespace _2_2_10_2_operatori
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Operatori:");
            int x = 2;
            x += 1;
            Console.WriteLine("X je jednak " +x);
            x -= 7;
            Console.WriteLine("X je sada " + x);

            int y = x++;
            Console.WriteLine("Y je sada " + y);
            y = x;
            Console.WriteLine("Y je tek sada " + y);

            Console.ReadKey();
        }
    }
}
