using System;

namespace _3._2_HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadKey();
            int a, b;
            a = Console.Read();
            b = Console.Read();
            float c = Zbroj(a, b);
            Console.WriteLine(c);
            Console.ReadKey();
        }

        static float Zbroj(int a, int b)
        {
            return a + b;
        }
    }
}
