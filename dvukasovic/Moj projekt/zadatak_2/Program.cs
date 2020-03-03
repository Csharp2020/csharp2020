using System;
using System.Collections;

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
            string recenica = "Ivica ide u skolu Antuna Antunovica";
            ArrayList a = new ArrayList();
            ArrayList b = new ArrayList();
            ArrayList c = new ArrayList();
            string[] rijec = recenica.Split();

            foreach (string s in rijec)
            {
                Console.Write(s[0] + " ");
                if (s == "A" || s == "a")
                {
                    a.Add(s);
                    Console.WriteLine(a.Count);
                }
                else if ( s == "I" || s == "i")
                {
                    b.Add(rijec);
                }
                
            }
            Console.WriteLine(a.Count);





        }
    }
}
