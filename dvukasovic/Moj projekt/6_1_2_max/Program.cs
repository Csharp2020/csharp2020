using System;
using System.Linq;

namespace _6_1_2_max
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi 5 brojeva, ispisi najveci crvenom bojom");
            
            int [] najveciod5 = new int[5];
            int m = najveciod5.Max();

            for (int i = 0; i < najveciod5.Length; i++)
            {
                Console.WriteLine("Unesi {0}. broj:", i + 1);
                najveciod5[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < najveciod5.Length; i++)
            {
                Console.Write(najveciod5[i] + " ");
            }

        }
    }
}
