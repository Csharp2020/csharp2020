using System;

namespace _5_3_11_savrseni_intervali
{
    class Program
    {
        static void Main(string[] args)
        {
            // Savršeni od [1,1000]
            Console.WriteLine("Unesite prirodan broj:");

            //  int a = int.Parse(Console.ReadLine());
            for (int a = 1; a < 1000; a++)
            {
                int broj = 0;

                for (int i = 1; i < a; i++)
                {
                    if (a % i == 0)
                    {
                        broj += i;
                    }
                }

                if (a == broj)
                {
                    Console.Write("{0} ",a);
                }

                else
                {
                    // Console.WriteLine("");
                }
            }

        }
    }
}
