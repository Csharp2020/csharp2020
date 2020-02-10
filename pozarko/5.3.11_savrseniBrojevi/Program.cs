using System;

namespace _5._3._11_savrseniBrojevi
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int x = 0;
            int j = 0;
            for(int i = 1; i < 1000; i++)
            {
                do
                {
                    Console.WriteLine("i: {0}, j: {1}", i, j);
                    if (i % j == 0)
                    {
                        n += j;
                        if (n == i)
                        {
                            Console.WriteLine("Broj je savrseni broj i iznosi: " + n);
                        }
                    }
                    j++;
                }while(j < i);
            }
            Console.WriteLine("n je jednak: " + n);
        }
    }
}
