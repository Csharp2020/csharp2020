using System;

namespace _7_2_6_prosti_broj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite prirodan broj:");
            int broj = int.Parse(Console.ReadLine());

            if (Prostbroj(broj))
            {
                Console.WriteLine("Prost broj.");
            }
            else
            {
                Console.WriteLine("Složen broj.");
            }
        }

        private static bool Prostbroj(int broj)
        {
            bool broj = true;

            for (int i = 2; i < broj; i++)
            {
                if (broj % i == 0)
                {
                    broj = false;
                }
            }
        }

       
    }
}
