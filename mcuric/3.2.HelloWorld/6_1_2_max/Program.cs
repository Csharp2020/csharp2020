using System;
using System.Linq;

namespace _6_1_2_max
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite 5 brojeva!");
            int[] brojevi = new int[5];
            for(int i = 0; i < brojevi.Length; i++)
            {
                Console.WriteLine("Unesite {0}. broj: ", i+1);
                brojevi[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Najveci broj medju navedenima je {0} i nalazi se na {1}. poziciji", brojevi.Max(), Array.IndexOf(brojevi, brojevi.Max()) );
            for(int i = 0; i < brojevi.Length; i++)
            {
                if (i == Array.IndexOf(brojevi, brojevi.Max()))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(brojevi[i] + " ");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else Console.Write(brojevi[i] + " ");
            }
            int pomoc;
            pomoc = brojevi.Max();
            int najveci = Array.IndexOf(brojevi, brojevi.Max());
            int najmanji = Array.IndexOf(brojevi, brojevi.Min());
            brojevi[najveci] = brojevi.Min();
            brojevi[najmanji] = pomoc;

            Console.WriteLine("Isti Array sa zamjenjenim mjestima najveceg i najmanjeg broja: ");
            foreach (var item in brojevi)
            {
                Console.Write(item + " ");
            }

            Console.ReadLine();
        }
    }
}
