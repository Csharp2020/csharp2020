using System;

namespace _8_2_2_2_prijenos_outz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int a;    // primjer bez vrijednosti
            int b=88;  // primjer s vrijednosti

            incijaliziraj(out a);
            Console.WriteLine("a je jednako="+a);

            incijaliziraj(out b);
            Console.WriteLine("b je jednako=" + b);


        }

        private static void incijaliziraj(out int a)
        {
            a = 55;
        }
    }
}
