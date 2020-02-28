using System;

namespace _7._2._6_prostBroj
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = int.Parse(Console.ReadLine());
            prosti(y);
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
