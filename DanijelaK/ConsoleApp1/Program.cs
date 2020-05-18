using System;
using System.Collections.Generic;

namespace _trazi_rijec
{
    class Program
    {
        static void Main(string[] args)
        {
            // traži sve riječi u rečenici koje počinju s unesenim slovom
            Console.WriteLine("Unesi recenicu");
            string recenica = Console.ReadLine();

            Console.WriteLine("Unesi početno slovo koje tražiš");
            string slovo = Console.ReadLine();

            string[] rijeci = recenica.Split(" ");

            Console.WriteLine("recenica ima {0} rijeci", rijeci.Length);
            // trazenje rijeci
            foreach (var item in rijeci)
            {
                if ((item.ToLower()).StartsWith(slovo.ToLower()))
                {

                    Console.WriteLine(item);
                    
                }
            }
            Console.WriteLine("-----------------");
            // okretanje recenice
            for (int i = rijeci.Length -1; i >= 0; i--)
            {
                Console.Write(rijeci[i]+ " ");
            }

        }
    }
}
