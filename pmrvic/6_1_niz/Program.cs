using System;

namespace _6_1_niz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            float[] niz = new float[4];
            niz[0] = 5.785f;
            niz[1] = 66;
            niz[2] = 77;
        //    niz[3] = 88; // ovaj niz ima samo tri elementa

            for (int i = 0; i < niz.Length; i++)
            {
                Console.Write(" "+niz[i]);
            }
            Console.WriteLine();

            foreach (int pero in niz)
            {
                Console.Write(" "+pero);
            }


        }
    }
}
