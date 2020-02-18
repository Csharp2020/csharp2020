using System;

namespace _7_1_1_zbroj
{
    class Program
    {
        static void Main(string[] args)
        {
            //trazi unos dva broja i ispisuje njihov zbroj
            //koristiti potprogram

            Console.WriteLine("Unesite dva broja: ");
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());

            Console.WriteLine("Zbroj zadanih brojeva iznosi {0}", Zbroj(a,b));
            Console.ReadLine();

            //trazi unos duljina dviju kateta pravokutnog trokuta i u potprogramu izracuna iznos hipotenuze
            Console.WriteLine("Unesite duljine dviju kateta pravokutnog trokuta:");
            Console.Write("a = ");
            double a1 = float.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            Console.Write("b = ");
            double b1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Hipotenuza vaseg pravokutnog trokuta iznosi {0}", Hipotenuza(a1, b1));
            Console.ReadLine();
        }
        static float Zbroj(float x, float y)
        {
            return x + y;
        }

        static double Hipotenuza(double x, double y)
        {
            return Math.Sqrt((x*x) + (y*y));
        }

    }
}
