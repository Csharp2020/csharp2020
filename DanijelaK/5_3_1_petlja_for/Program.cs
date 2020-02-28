using System;

namespace _5_3_1_petlja_for
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Petlja for");

            // 0 1 2 3 4 5 6 7 8 9
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i+ " ");
            }
            Console.WriteLine();

            // 0 2 4 6 8
            for (int i = 0; i < 10; i+=2)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            // 10 9 8 7 6 5 4 3 2 1
            for (int i = 10; i > 0; i --)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            // 7 14 21 28 35 42 49 56 63 70
            for (int i = 7; i < 77; i+=7)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
