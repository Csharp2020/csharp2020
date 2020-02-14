using System;

namespace _7._3.kvadrat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kvadriramo broj");

            int broj = int.Parse(Console.ReadLine());

            Console.WriteLine("broj {0} je na kvadrat jednak {1}", broj, Kvadrat(broj));

            Console.WriteLine("broj {0} je na kub jednak {1}", broj, Kub(broj));

            Console.WriteLine("broj {0} je na 4. exponent jednak {1}", broj, NaCetvrtu(broj));
        }

        private static int NaCetvrtu(int broj)
        {
            //return Kub(broj) * broj;
            return (int)Math.Pow(broj, 4); // zato šta Math.Pow vraca double
        }

        private static int Kub(int broj)
        {
            return Kvadrat(broj) * broj;
        }

        private static int Kvadrat(int broj)
        {
            return broj * broj;
        }
    }
}
