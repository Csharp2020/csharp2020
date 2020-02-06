using System;

namespace _5_2_3_velikiBroj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesibroj");
            double a = double.Parse(Console.ReadLine());
            if (a >= 100)
            {
                Console.WriteLine("Broj je veci ili jednako 100");
            }
            else
            {
                Console.WriteLine("Broj je manji od 100");
            }
        }
    }
}
