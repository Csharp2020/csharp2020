using System;
using System.Collections;
using System.Collections.Generic;

namespace _7._2._11_parNep
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Unos();
        }

        private static void Unos()
        {
            List<int> brojevi = new List<int>();
            int i = 0;
            int x;
            do
            {
                x = int.Parse(Console.ReadLine());
                brojevi.Add(x);
                i++;
            } while (x != 0);
            foreach (var item in brojevi)
            {
                Parni(item);
                Neparni(item);
            }
        }

        private static void Parni(int x)
        {
            List<int> parni = new List<int>();
            if (x % 2 == 0 && x!=0)
            {
                parni.Add(x);
            }

            foreach (var item in parni)
            {
                ispisParni(item);
            }
        }

        private static void Neparni(int x)
        {
            List<int> neparni = new List<int>();
            if (x % 2 != 0 && x!=0)
            {
                neparni.Add(x);
            }

            foreach (var item in neparni)
            {
                ispisiNep(item);
            }
        }
        private static void ispisiNep(int x)
        {
            Console.Write("N"+x + " ");
        }

        private static void ispisParni(int x)
        {
            Console.Write("P"+x + " ");
        }
    }
}
