using System;

namespace Pr6._1._1_unosIspis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi 10 prirodnih br. i ispisi i");
            int[] brDoDeset = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Unesi {0}. broj", (i + 1));
                brDoDeset[i] = int.Parse(Console.ReadLine());
            }


            //Ispis unaprijed
            for (int i = 0; i < brDoDeset.Length; i++)
            {
                Console.Write(brDoDeset[i] + " ");
            }
            Console.WriteLine();

            //Ispis unatrag 1. nacin
            for (int i = brDoDeset.Length; i > 0; i--)
            {
                Console.Write(brDoDeset[i-1] + " ");
            }
            Console.WriteLine();

            //Ispis unaprijed svaki drugi
            for (int i = 0; i < brDoDeset.Length; i+=2)
            {
                Console.Write(brDoDeset[i] + " ");
            }
            Console.WriteLine();

            //Sortiranje
            Array.Sort(brDoDeset);
            for (int i = 0; i < brDoDeset.Length; i++)
            {
                Console.Write(brDoDeset[i] + " ");
            }
            Console.WriteLine();

            //Sortiranje unazad
            Array.Reverse(brDoDeset);
            for (int i = 0; i < brDoDeset.Length; i++)
            {
                Console.Write(brDoDeset[i] + " ");
            }
            Console.WriteLine();

            //Trazenje broja u nizu
            int nadiPet = Array.IndexOf(brDoDeset, 5);
            if (nadiPet < 0)
            {
                Console.WriteLine("Trazeni broj se ne nalazi u nizu");
            }
            else
            {
                Console.WriteLine("Broj 5 se nalazi na {0} mjestu.", nadiPet);
            }
            
        }
    }
}
