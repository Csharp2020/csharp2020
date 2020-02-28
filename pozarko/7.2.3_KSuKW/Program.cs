using System;

namespace _7._2._3_KSuKW
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite KS.");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(Pretvorba(x));

        }

        private static float Pretvorba(int x)
        {
            float y = x*0.736f; 
            return y;
        }
    }
}
