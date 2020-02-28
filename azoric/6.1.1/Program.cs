using System;

namespace _6._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi 10 pruirodnih br. i ispisi i");

            int[] brojevidodeset = new int[10];
            // ispis naprijed
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Unesi {0}. broj:", i + i);
                brojevidodeset[i] = int.Parse(Console.ReadLine());
            }
            //ispis unatrag 1.nacin
            for (int i = 0; i < brojevidodeset.Length; i--)
            {
                Console.Write(brojevidodeset[i - 1] + " ");
            }
            // ispis unaprijed svaki drugi
            for (int i = 0; i < brojevidodeset.Length; i+=2)
            {
                Console.WriteLine(brojevidodeset[i] + " ");
            }
            Array.Sort(brojevidodeset);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Unesi {0}. broj:", i + i);
                brojevidodeset[i] = int.Parse(Console.ReadLine());
            }
        }
    }
}
