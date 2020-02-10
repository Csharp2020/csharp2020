using System;

namespace _5._2._7_dobarBroj_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            if (x % 4 == 0 && x >= 100)
            {
                Console.WriteLine("Broj je dobar");
            }
            else { Console.WriteLine("Broj NIJE dobar"); }
        }
    }
}
