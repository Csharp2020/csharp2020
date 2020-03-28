using System;

namespace _8._2._1_Static
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Static klasa - DOSEG varijabli");

            Console.WriteLine(MojStatic.Zbroj(broj1: 7.8, broj2: 15.8));

            Console.WriteLine(MojStatic.CelzijFahrenheit(x: 25));
        }
    }
}
