using System;

namespace _7_2_5_udaljenost
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi x koordinatu točke P1:");
            double x1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Unesi y koordinatu točke P1:");
            double y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Unesi x koordinatu točke P2:");
            double x2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Unesi x koordinatu točke P2:");
            double y2 = double.Parse(Console.ReadLine());

            Console.WriteLine("d= {0}", d(x1, y1, x2, y2));
        }

        private static double d(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt ((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1));
        }
    }
}
