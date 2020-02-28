using System;

namespace _7._2._10_ukCijena
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite cijenu.");
            float y = float.Parse(Console.ReadLine());
            Console.WriteLine(UkCijena(y));
        }

        private static double UkCijena(float x)
        {
            double ukC=0;
            if (x < 100)
            {
                ukC = x + 5.5 + x * 0.02 + x * 0.25;
            }
            else if(x>=100 && x <= 250)
            {
                ukC = x + 9.5 + x * 0.03 + x * 0.25;
            }
            else if(x >= 250 && x <= 500)
            {
                ukC = x + 15 + x * 0.04 + x * 0.25;
            }
            else if (x >= 500 && x <= 1000)
            {
                ukC = x + 25 + x * 0.05 + x * 0.25;
            }
            else if (x > 1000)
            {
                ukC = x + 50 + x * 0.1 + x * 0.25;
            }
            return ukC;
        }
    }
}
