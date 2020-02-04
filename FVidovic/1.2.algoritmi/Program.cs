using System;

namespace _1._2.algoritmi
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ovo je blok komentar
             * */
            // Ovo je linijski komentar
            Console.WriteLine("Hello World!");
            float a, b;
            Console.WriteLine("Unesi prvi broj");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Unesi drugi broj");
            b = float.Parse(Console.ReadLine());

            float c = Zbroj(a, b);
            Console.WriteLine(c);

        }

        private static float Zbroj(float a, float b)
        {
            return a + b;

        }
    }
}
