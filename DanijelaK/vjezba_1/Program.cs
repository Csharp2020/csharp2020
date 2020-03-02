using System;
using System.Collections.Generic;

namespace vjezba_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zadatak2: Napišite program koji traži unos riječi sve dok se ne unese riječ "kraj".
            //1.Program ispisuje:
            //            Riječi koje počinju slovom A: ...
            //Riječi koje počinju slovom B: ...
            //Riječi koje počinju slovom C: ...
            //Ostale riječi: ...
            string rijec="";

            List<string> reci = new List<string>();
            List<string> ostaleRijeci = new List<string>();
            while (rijec != "kraj")
            {
                Console.WriteLine("Unesite riječ: ");

                rijec = Console.ReadLine();
                if (rijec!="kraj")
                {
                    reci.Add(rijec);
                    ostaleRijeci.Add(rijec);
                }
               
                //if (rijec=="kraj")
                //{
                //    break;
                //}
            }
            // ostaleRijeci = reci;

            Console.WriteLine("Riječi koje počinju sa slovom a: ");

            foreach (var item in reci)
            {
                if (item.StartsWith("a") || item.StartsWith("A"))
                {
                    Console.Write(item + " ");
                    ostaleRijeci.Remove(item);

                }
            }
            Console.WriteLine();
            Console.WriteLine("Riječi koje počinju sa slovom b: ");
            foreach (var item in reci)
            {
                if (item.StartsWith("b") || item.StartsWith("B"))
                {
                    Console.Write(item + " ");
                    ostaleRijeci.Remove(item);

                }
            }

            Console.WriteLine();
            Console.WriteLine("Riječi koje počinju sa slovom c: ");
            foreach (var item in reci)
            {
                if (item.ToLower().StartsWith("c"))
                {
                    Console.Write(item + " ");
                    ostaleRijeci.Remove(item);

                }
            }
            Console.WriteLine();
            Console.WriteLine("Ostale rijeci:");
            foreach (var item in ostaleRijeci)
            {
                Console.Write(item +" ");
            }
        }
    }
}
