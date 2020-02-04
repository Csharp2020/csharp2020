using System;

namespace _5_1_3_ucitavanje_s_tipkovnice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Unesite radijus");
            int broj = int.Parse(Console.ReadLine());
            Console.WriteLine("Uneseni radijus je {0}, pa stoga površina kruga iznosi {1}, a njegov opseg {2}",
                                                                        broj, broj*broj*Math.PI, (broj+broj)*Math.PI);
            Console.ReadLine();
        }
    }
}
