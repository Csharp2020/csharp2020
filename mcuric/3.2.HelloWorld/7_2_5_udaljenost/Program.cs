using System;

namespace _7_2_5_udaljenost
{
    class Program
    {
        static void Main(string[] args)
        {
            //izraditi funkciju koja racuna udaljenost izmedju dvije tocke

            Console.WriteLine("Unesite koordinate prve točke");
            Console.Write("x1 = ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("y1 = ");
            double y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Unesite koordinate druge točke");
            Console.Write("x2 = ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("y2 = ");
            double y2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Udaljenost danih tocaka je {0}", UdaljenostTocaka(x1,y1,x2,y2));
            Console.ReadLine();
        }

        static double UdaljenostTocaka(double a1, double b1, double a2, double b2)
        {
            return Math.Sqrt(((a2-a1)*(a2-a1))+((b2-b1)*(b2-b1)));
        }
    }
}
