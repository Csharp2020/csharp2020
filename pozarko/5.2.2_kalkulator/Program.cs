using System;

namespace _5._2._2_kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Unos prvog broja
            Console.WriteLine("Unesite prvi broj");
            int br1 = int.Parse(Console.ReadLine());

            //Unos drugog
            Console.WriteLine("Unesite drugi broj");
            int br2 = int.Parse(Console.ReadLine());

            //Unos operacije
            Console.WriteLine("Odaberite operaciju:\n+ ili -");
            char op = char.Parse(Console.ReadLine());

            //Zbrajanje
            if (op == '+')
            {
                Console.WriteLine("Rjesenje je:" +(br1 + br2));
            }

            //Oduzimanje
            else if (op == '-')
            {
                Console.WriteLine("Rjesenje je:" +(br1 - br2));
            }
        }
    }
}
