using System;
using System.Collections.Generic;

namespace zadatak_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //unesi tekst : Ivica ide u školu Antuna Antunovića
            // napravi 3 liste
            Console.WriteLine("Unesite rečenicu:");
            string rijec = Console.ReadLine();
            string [] r = rijec.Split();
         

            List<string> a_lista = new List<string>();
            List<string> i_lista = new List<string>();
            List<string> o_lista = new List<string>();

            foreach (var item in r)
            {
                if (item.StartsWith("a") || item.StartsWith("A"))
                {
                    a_lista.Add(item); 
                }
            }

            foreach (var item in r)
            {
                if (item.StartsWith("i") || item.StartsWith("I"))
                {
                    i_lista.Add(item);
                }
            }
            foreach (var item in r)
            {
                   
                if (item.StartsWith("i") || item.StartsWith("I") || item.StartsWith("a") || item.StartsWith("A"))
                {
                 
                }
                else
                {
                    o_lista.Add(item);
                }
            }

            Console.WriteLine($"Broj rijeci u a_listi: {a_lista.Count} ");
            Console.WriteLine($"Broj rijeci u i_listi: {i_lista.Count} ");
            Console.WriteLine($"Broj rijeci u o_listi: {o_lista.Count} ");

        }
    }
}
