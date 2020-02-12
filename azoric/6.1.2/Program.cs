using System;
using System.Linq;

namespace _6._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int [] najveciod5 = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Unesi {0}. broj", (i + 1));
                najveciod5[i] = int.Parse(Console.ReadLine());
            }

            //nadji najveci broj
            int najveci = najveciod5.Max();
            //ispis unaprijed
            int pozicijaMax = Array.IndexOf(najveciod5, najveci);
            for (int i = 0; i < najveciod5.Length; i++)
            {
                if(i == pozicijaMax)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(najveciod5[i] + " ");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else
                {
                    Console.WriteLine(najveciod5[i] + " ");
                }
                Console.WriteLine(najveciod5[i] + " ");
            }
            // DRUGI NACIN

            //nadji najveci broj
            int najveci2 = najveciod5[0];
            for (int i = 0; i < najveciod5.Length; i++)
            {
                if (najveciod5[i] > najveci2)
                {
                    najveci2 = najveciod5[i];
                }
                else
                {
                    Console.WriteLine(najveciod5[i] + " ");
                }
            }

        }
        

    }
}
