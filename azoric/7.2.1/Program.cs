using System;

namespace _7._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int broj = int.Parse(Console.ReadLine());

            Console.WriteLine("opseg kruga je {1}", broj, Opseg(broj));
            Console.WriteLine("povrsina kruga je {1}", broj, Povrsina(broj));
        }

        private static double Povrsina(int broj)
        {
            return broj * broj * Math.PI;
        }

        private static double Opseg(int broj)
        {
            return 2 * broj * 3.14;
        }
    }
}
