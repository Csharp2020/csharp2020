using System;

namespace Unos_ispis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unos ispis");

            int[] niz = new int[10];
            for (int i = 0; i < niz.Length; i++)
            {
                Console.WriteLine("Unesite {0} broj niza", i);
                niz[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Brojevi u nizu su: ");
            for (int i = 0; i < niz.Length; i++)
            {
                Console.WriteLine(niz[i]);
            }
        }
    }
}
