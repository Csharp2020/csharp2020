using System;

namespace _5_2_7_dobar_broj_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite broj!");
            int a = int.Parse(Console.ReadLine());
            if (a % 4 == 0 && a >= 100) 
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
