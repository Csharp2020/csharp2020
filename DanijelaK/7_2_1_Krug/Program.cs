using System;

namespace _7_2_1_Krug
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ispis opsega i površine kruga");

            double r = double.Parse(Console.ReadLine());

            Console.WriteLine("Opseg kruga je {0}", Opseg(r));
            Console.WriteLine("Opseg kruga je {0}", Povrsina(r));

        }

        private static double Povrsina(double r)
        {
            return r * r * Math.PI;
        }

        private static double Opseg(double r)
        {
            return 2 * r * Math.PI;
        }
    }
}
