using System;

namespace _8_2_2_1_referentni_tipovi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int x = 1;
            PovecajPrvi(x);
            Console.WriteLine("x = {0}", x);

            PovecajDrugi(ref x);
            Console.WriteLine("x = {0}", x);

            PovecajPrvi(x);
            Console.WriteLine("x = {0}", x);
            PovecajPrvi(x);
            Console.WriteLine("x = {0}", x);
            PovecajPrvi(x);
            Console.WriteLine("x = {0}", x);


            int a;
            Inicijaliziraj(out a);
            int b = 6;
            Inicijaliziraj(out b);
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);


            Console.ReadLine();
        }

        private static void Inicijaliziraj(out int a)
        {
            a = 1;
        }

        private static void PovecajDrugi(ref int x)
        {
            x++;
        }

        private static void PovecajPrvi(int x)
        {
            x++;
        }
    }
}
