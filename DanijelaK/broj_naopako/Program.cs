using System;

namespace broj_naopako
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite broj");

            int broj = int.Parse(Console.ReadLine());

             for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i + " ");
            }
        }
    }
}
