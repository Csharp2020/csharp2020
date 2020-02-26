using System;

namespace _7._2._4_CtoF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            float c = float.Parse(Console.ReadLine());
            Console.WriteLine(CtoF(c));
        }

        private static float CtoF(float x)
        {
            float f = (9 / 5) * x + 32;
            return f;
        }
    }
}
