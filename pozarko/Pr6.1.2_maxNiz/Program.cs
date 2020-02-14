using System;
using System.Linq;

namespace Pr6._1._2_maxNiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi 5 brojeva, ispisi najveci broj i ispisi ga crvenom bojom.");
            int[] najveciOdPet = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Unesi {0}. broj", (i + 1));
                najveciOdPet[i] = int.Parse(Console.ReadLine());
            }





            //nadi najveci broj
            int najveci = najveciOdPet.Max();

            //nedi poziciju najveceg broja
            int pozicijaMax = Array.IndexOf(najveciOdPet, najveci);

            
            for (int i = 0; i < najveciOdPet.Length; i++)
            {
                if (i == pozicijaMax)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(najveciOdPet[i] + " ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write(najveciOdPet[i] + " ");
                }
                
            }
            Console.WriteLine();

            //DRUGI NACIN

            //nadji koji je najveci broj
            int najveci2 = najveciOdPet[0];

            for(int i = 0; i < najveciOdPet.Length; i++)
            {
                if (najveciOdPet[i] > najveci2)
                {
                    najveci2 = najveciOdPet[i];
                }
            }
            //nedi poziciju najveceg broja
            pozicijaMax = Array.IndexOf(najveciOdPet, najveci);


            for (int i = 0; i < najveciOdPet.Length; i++)
            {
                if (i == pozicijaMax)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(najveciOdPet[i] + " ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write(najveciOdPet[i] + " ");
                }

            }
            Console.WriteLine();
        }
    }
}
