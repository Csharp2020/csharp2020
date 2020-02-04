using System;

namespace _5._2._3_velikiBroj
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = int.Parse(Console.ReadLine());
            if (i > 99)
            {
                Console.WriteLine("Broj je velik");
            }
            else
            {
                Console.WriteLine("Broj NIJE velik");
            }
        }
    }
}
