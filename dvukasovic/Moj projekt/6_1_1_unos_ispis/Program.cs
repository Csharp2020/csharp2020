using System;

namespace _6_1_1_unos_ispis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi 10 prirodnih brojeva i ispisi i");

            int[] brojeviDoDeset = new int[10];

            for (int i = 0; i < brojeviDoDeset.Length; i++)
            {
                Console.WriteLine("Unesi {0}. broj:", i+1);
                brojeviDoDeset[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < brojeviDoDeset.Length; i++)
            {
                Console.Write(brojeviDoDeset[i] + " ");
            }

            for (int i = brojeviDoDeset.Length-1; i >= 0; i--)
            {
                Console.Write(brojeviDoDeset[i] + " ");
            }
        }
    }
}
