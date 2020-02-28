using System;

namespace _7_2_3_ks_u_kw
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite snagu u KS:");
            double ks = double.Parse(Console.ReadLine());

            Console.WriteLine("Snaga u kilovatima je {0}.", Snaga(ks));
        }

        private static double Snaga(double ks)
        {
            return ks * 0736;
        }
    }
}
