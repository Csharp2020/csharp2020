using System;

namespace _7._2._7_prostBrojPonovo
{
    class Program
    {
        static void Main(string[] args)
        {
            char x = 'D';
            do
            {
                Console.WriteLine("Unesite broj.");
                int y = int.Parse(Console.ReadLine());
                prosti(y);
                Console.WriteLine("Dali želite nastaviti unositi brojeve? \nD/N");
                x = char.Parse(Console.ReadLine());
            } while (x != 'N');
        }
        private static void prosti(int x)
        {
            int k = 2;
            for (int i = 0; i < x; i++)
            {
                if (x == k)
                {
                    Console.WriteLine("Broj je prost.");
                }
                else if (x % k == 0)
                {
                    Console.WriteLine("Broj nije prost.");
                    break;
                }

                else
                {
                    k++;
                }
            }
        }
    }
}
