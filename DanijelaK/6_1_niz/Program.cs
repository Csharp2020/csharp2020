using System;

namespace _6_1_niz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] niz = new int[4];
            niz[0] = 55;
            niz[1] = 66;
            niz[2] = 77;
            // niz[3] = 88; // niz ima samo tri elementa

            for (int i = 0; i < niz.Length; i++)
            {
                Console.Write(" " + niz[i]);
            }

            foreach (var item in niz)
            {
                Console.Write(" " + item);
            }
        }
    }
}
