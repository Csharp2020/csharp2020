using System;
using System.Collections.Generic;

namespace zadatak2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string rijec = "";
            List<string> a = new List<string>();
            List<string> b = new List<string>();
            List<string> c = new List<string>();
            do
            {
                string unos = Console.ReadLine();
                
                if (unos.Substring(0, 1) == "a")
                {
                    a.Add(unos);
                }
                else if (unos.Substring(0, 1) == "A")
                {
                    a.Add(unos);
                }
                else if (unos.Substring(0, 1) == "b")
                {
                    b.Add(unos);
                }
                else if (unos.Substring(0, 1) == "B")
                {
                    b.Add(unos);
                }
                else if (unos.Substring(0, 1) == "C")
                {
                    c.Add(unos);
                }
                else if (unos.Substring(0, 1) == "c")
                {
                    c.Add(unos);
                } else if (unos == "kraj")
                {
                    rijec = unos;
                }
            } while (rijec != "kraj");

            Console.WriteLine("rijci sa a su :");
            for (int i = 0; i < a.Count; i++)
            {
                Console.WriteLine(a[i]);
            }

            Console.WriteLine("rijci sa b su :");
            for (int i = 0; i < b.Count; i++)
            {
                Console.WriteLine(b[i]);
            }

            Console.WriteLine("rijci sa c su :");
            for (int i = 0; i < c.Count; i++)
            {
                Console.WriteLine(c[i]);
            }
        }
    }
}
