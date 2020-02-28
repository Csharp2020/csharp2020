using System;
using System.Linq;
namespace _6_1_2_max
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi 5 brojeva, ispiši najveći sa crvenom bojom");

            int[] najveciod5 = new int[5];

            for (int i = 0; i < najveciod5.Length; i++)
            {
                Console.WriteLine("Unesi {0}. broj:", i + 1);
                najveciod5[i] = int.Parse(Console.ReadLine());
            }
            

            //nađi koji je najveći broj
            int najveci = najveciod5.Max();

            //nađi poziciju
            int pozicijamax = Array.IndexOf(najveciod5, najveci);

            // ispis naprijed

            for (int i = 0; i < najveciod5.Length; i++)
            {
                if (i==pozicijamax)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(najveciod5[i] + " ");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else
                {
                    Console.Write(najveciod5[i] + " ");
                }
                
            }

            // DRUGI NAČIN

            //nađi koji je najveći broj
            int najveci2 = najveciod5[0];

            for (int i = 1; i < najveciod5.Length; i++)
            {
                if (najveciod5[i]>najveci2)
                {
                    najveci2 = najveciod5[i];
                }
            }

            //nađi poziciju
            pozicijamax = Array.IndexOf(najveciod5, najveci2);

            // ispis naprijed

            for (int i = 0; i < najveciod5.Length; i++)
            {
                if (i == pozicijamax)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(najveciod5[i] + " ");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else
                {
                    Console.Write(najveciod5[i] + " ");
                }

            }
        }
    }
}
