using System;

namespace Krug
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite radijus");
            int radijus = int.Parse(Console.ReadLine());
            Console.WriteLine("Opseg kruga s radijusom " + radijus + " je " + Math.Round(OpsegKruga(radijus)));
            Console.WriteLine("Površina kruga s radijusom {0} je {1}", radijus, Math.Round(PovrsinaKruga(radijus), 2));
        }
        static double OpsegKruga(double radijus)
        {
            return 2 * radijus * Math.PI;
        }
        static double PovrsinaKruga(double radijus)
        {
            return radijus * radijus * Math.PI;
        }


    }
}
