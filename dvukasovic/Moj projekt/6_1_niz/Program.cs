using System;

namespace _6_1_niz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] niz = new int[3];
            niz[0] = 55;
            niz[1] = 66;
            niz[2] = 77;

            for (int i = 0; i < niz.Length; i++)
            {
                Console.WriteLine(niz[i]);
            }
        }
    }
}
