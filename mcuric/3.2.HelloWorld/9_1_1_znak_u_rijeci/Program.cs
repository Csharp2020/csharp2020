using System;

namespace _9_1_1_znak_u_rijeci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite rijec!");
            string rijec = Console.ReadLine();
            Console.WriteLine("Unesite znak koji zelite naci: ");
            string znak = Console.ReadLine();
            int kolikoputa = 0;
            while(rijec.IndexOf(znak) != -1)
            {
                
                rijec = rijec.Substring(rijec.IndexOf(znak) + 1);
                kolikoputa++;
            }
            Console.WriteLine($"Znak {znak} se pojavljuje {kolikoputa} u rijeci {rijec} ");
            Console.ReadLine();
        }
    }
}
