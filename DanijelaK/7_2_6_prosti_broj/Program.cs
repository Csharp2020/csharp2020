using System;

namespace _7_2_6_prosti_broj
{
    class Program
    {
        static void Main(string[] args)
        {
            string odg = "d";
            while (odg == "D" || odg == "d")
            {
                Console.WriteLine("Unesite prirodan broj:");
                int broj = int.Parse(Console.ReadLine());

                if (Prost(broj))
                {
                    Console.WriteLine("Prost broj.");
                }
                else
                {
                    Console.WriteLine("Složen broj.");
                }
                Console.WriteLine("Želite li ponovo (D/N)?");
                odg = Console.ReadLine();
            }
        }

        private static bool Prost(int broj)
        {
            for (int i = 2; i < broj; i++)
            {
                if (broj % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

    }
}
