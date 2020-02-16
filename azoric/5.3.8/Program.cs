using System;

namespace _5._3._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int rezultat = 0;

            for (int i = 1; i <= 1000; i++)
            {
                if (i % 7 ==0 && i % 3 != 0)
                {
                    rezultat = rezultat + 1;
                 

                }

            }

            Console.WriteLine(rezultat);
            
        }
    }
}
