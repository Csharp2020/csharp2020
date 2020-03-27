using System;

namespace Niz_Max
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Niz + ispis max");
            int[] niz = new int[5];
            int max = 0;
            for (int i = 0; i < niz.Length; i++)
            {
                Console.WriteLine("Unesite {0} broj niza", i);
                niz[i] = int.Parse(Console.ReadLine());

                if (max < niz[i])
                {
                    max = niz[i];
                }
            }

            for (int i = 0; i < niz.Length; i++)
            {
                if (max == niz[i])
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                Console.WriteLine(niz[i]);
                Console.ResetColor();
            }
        }
    }
}
