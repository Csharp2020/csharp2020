using System;

namespace _7_3_funkcije_kvadrat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kvadriramo broj");

            int broj = int.Parse(Console.ReadLine());

            Console.WriteLine("broj {0} je na kvadrat jednak {1}", broj, Kvadrat(broj));
            Console.WriteLine("broj {0} je na kub jednak {1}", broj, Kub(broj));
            Console.WriteLine("broj {0} je na 4. eksponent jednak {1}", broj, NaCetvrtu(broj));
        }

        private static int NaCetvrtu(int broj)
        {
            // return Kub(broj) * broj;
            // return Kvadrat(broj) * Kvadrat(broj);
            // return broj * broj * broj * broj;
            // return Kvadrat(broj) * broj * broj;
            // return Kvadrat(Kvadrat(broj));
            return (int)Math.Pow(broj, 4);



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
