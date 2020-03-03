using System;

namespace _5._3._11_savrseniBrojevi
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            for(int i = 1; i <= 1000; i++)
            {
                n = 0;
                for(int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        n += j;

                    }
                }
                if (i == n)
                {
                    Console.WriteLine("Broj je savrsen i iznosi: " + n);
                }
            }
            Console.WriteLine("n je jednak: " + n);
        }
    }
}
