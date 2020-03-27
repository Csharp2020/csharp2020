using System;

namespace _5_3_1_for
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Petlja for");

            for (int i = 0; i < 10; i++)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();

            for (int i = 0; i < 10; i+=2)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine(); // la la asdasdasd

            for (int i = 10; i > 0; i--)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            for (int i = 10; i > 0; i--)
            {
                Console.Write(i + " ");
            }
        }
    }
}
