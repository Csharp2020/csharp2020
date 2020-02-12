using System;

namespace _6_1_1_unos_ispis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi 10 prirodnih brojeva i ispiši ih:");
            // int[] brojevidodeset = new int[10];
            int[] brojevidodeset = new int[5];

            for (int i = 0; i < brojevidodeset.Length; i++)
            {
                Console.WriteLine("Unesi {0}. broj:", i + 1);
                brojevidodeset[i] = int.Parse(Console.ReadLine());
            }

            // ispis naprijed

            for (int i = 0; i < brojevidodeset.Length; i++)
            {
                Console.Write(brojevidodeset[i] + " ");
            }

            // ispis unatrag

            Console.WriteLine();

            for (int i = brojevidodeset.Length-1; i >= 0;  i--)
            {
                Console.Write(brojevidodeset[i] + " "); 
            }

            // ispis unatrag 2. nacin

            Console.WriteLine();

            for (int i = brojevidodeset.Length; i >= 0; i--)
            {
                Console.Write(brojevidodeset[i-1] + " "); 
            }

            Console.WriteLine();

            // ispis naprijed svaki drugi

            for (int i = 0; i < brojevidodeset.Length; i+=2)
            {
                Console.Write(brojevidodeset[i] + " ");
            }

            Array.Sort(brojevidodeset);
            Console.WriteLine();

            for (int i = 0; i < brojevidodeset.Length; i++)
            {
                Console.Write(brojevidodeset[i] + " ");
            }

            Array.Reverse(brojevidodeset);
            Console.WriteLine();

            for (int i = 0; i < brojevidodeset.Length; i++)
            {
                Console.Write(brojevidodeset[i] + " ");
            }

            int nadjipet= Array.IndexOf(brojevidodeset, 5);

            if (nadjipet<0)
            {
                Console.WriteLine("Traženi broj se ne nalazi u nizu");
            }
            else
            {
                Console.WriteLine("Broj 5 se nalazi na {0}. mjestu", nadjipet+1);
            }
            

        }
    }
}
