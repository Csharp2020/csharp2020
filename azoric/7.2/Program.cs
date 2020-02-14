using System;

namespace _7._2
{
    class Program
    {
        static void Main(string[] args)
        {
           for (int i = 0; i < 10; i++)
            {
                HelloWorld();
                Console.WriteLine();
            }
        }
         static void HelloWorld ()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
