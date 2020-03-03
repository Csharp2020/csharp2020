using System;

namespace _5._3._10_savrseniBroj
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int n=0;
            for(int i = 1; i < x; i++)
            {
                if ((x % i) == 0)
                {
                    n += i;
                }
            }
            if (x == n)
            {
                Console.WriteLine("Broj je jednak zborju njegovih djelitelja i iznosi: " + x);
            }
            else
            {
                Console.WriteLine("Broj {0} nije jednak zbroju njegovih djelitelja jer iznosi {1}.", x, n);
            }
        }
    }
}
