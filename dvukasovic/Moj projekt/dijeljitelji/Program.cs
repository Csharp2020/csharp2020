using System;

namespace dijeljitelji
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dijeljitelji");
            Console.WriteLine("Unesei prirodan broj madafaka");
            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i < x; i++)
            {
                if (x % i == 0)
                {
                    Console.WriteLine("Dijeljitelji od {0} su {1}", x, i);
                }
            }
        }
    }
}
