using System;
using System.Collections;
using System.Collections.Generic;

namespace zadatak_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Unesi tekst "Ivica ide u skolu Antuna Antunovica"
              3 liste -1. <list> pocinju sa slovom "a"
              2. <list> pocinje sa slovom "i"
              3.<list> ostale rijeci koje ne pocinju sa a i i
              ipisi koliko koja lista ima rijci

            */
            List<string> a = new List<string>();
            List<string> b = new List<string>();
            List<string> o = new List<string>();

            string t = Console.ReadLine();

            string[] rijeci = t.Split(" ");
            for (int i = 0; i < rijeci.Length; i++)
            {
                if (rijeci[i].Substring(0, 1) == "a")
                {
                    a.Add(rijeci[i]);
                }
                else if (rijeci[i].Substring(0, 1) == "A")
                {
                    a.Add(rijeci[i]);
                }
                if (rijeci[i].Substring(0, 1) == "i")
                {
                    b.Add(rijeci[i]);
                }
                else if (rijeci[i].Substring(0, 1) == "I")
                {
                    b.Add(rijeci[i]);
                }
                else
                {
                    o.Add(rijeci[i]);
                }
            }
            Console.WriteLine("a " + a.Count);
            Console.WriteLine("i " + b.Count);
            Console.WriteLine("ostalo " + o.Count);





        }
    }
}
