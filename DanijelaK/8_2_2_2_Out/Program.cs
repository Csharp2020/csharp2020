using System;

namespace _8_2_2_2_Out
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Out");

            int a;
            int b = 88;

            inicijaliziraj(out a);
            Console.WriteLine("a="+a);

            inicijaliziraj(out b);
            Console.WriteLine("b=" + b);
        }

        private static void inicijaliziraj(out int a)
        {
            a = 55;
        }
    }
}
