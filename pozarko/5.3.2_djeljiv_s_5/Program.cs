using System;

namespace _5._3._2_djeljiv_s_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            do
            {
                n++;
                if (n % 5 == 0 && n > 5)
                {
                    Console.WriteLine(n);
                }
            } while (n != 101);
        }
    }
}
