using System;
using System.Collections.Generic;

namespace zamjena_mjesta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zamjena mjesta u nizu");
            int[] niz = new int[5];
            int max = int.MinValue;
            int min = int.MaxValue;
            int maxPozicija = 0;
            int minPozicija = 0;
            for (int i = 0; i < niz.Length; i++)
            {
                Console.WriteLine("Unesite {0} broj niza", i);
                niz[i] = int.Parse(Console.ReadLine());

                if (max < niz[i])
                {
                    max = niz[i];
                    maxPozicija = i;
                }
                else if (min > niz[i])
                {
                    min = niz[i];
                    minPozicija = i;
                }

            }

            int privremeni = niz[minPozicija];
            niz[minPozicija] = niz[maxPozicija];
            niz[maxPozicija] = privremeni;

            Console.WriteLine("Ispisujem");
            for (int i = 0; i < niz.Length; i++)
            {
                if (i == minPozicija || i == maxPozicija)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                }
                Console.WriteLine(niz[i]);
                Console.ResetColor();
            }
        }
    }
}
