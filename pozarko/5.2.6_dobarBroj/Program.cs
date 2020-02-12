using System;

namespace _5._2._6_dobarBroj
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = int.Parse(Console.ReadLine());
            if (i % 3 == 0|| i % 5 == 0)
            {
                Console.WriteLine("Broj je dobar");
            }
            else
            {
                Console.WriteLine("Broj nije dobar");
            }
        }
    }
}
