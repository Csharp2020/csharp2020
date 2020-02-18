using System;
using System.Collections.Generic;

namespace _7_2_11_parni_i_neparni
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite broj i nastavite unositi brojeve sve dok ne unesete 0!");
            List<int> listaBrojeva = new List<int>();
            while (!(listaBrojeva.Contains(0)))
            {
                listaBrojeva.Add(UnesiBroj());
            }

            List<int> listaParnih = new List<int>();
            IzdvojiParne(listaBrojeva, listaParnih);
            listaParnih.Remove(0);
            List<int> listaNeparnih = new List<int>();
            IzdvojiNeparne(listaBrojeva, listaNeparnih);
            listaNeparnih.Remove(0);

            IspisiListe(listaParnih, listaNeparnih);

            Console.ReadLine();
        }

        static int UnesiBroj()
        {
            int a = int.Parse(Console.ReadLine());
            return a;
        }

        static int IzdvojiParne(List<int> x, List<int> y)
        {
            foreach (var item in x)
            {
                if (item % 2 == 0)
                {
                    y.Add(item);
                }
            }
            return 0;
        }

        static int IzdvojiNeparne(List<int> x, List<int> y)
        {
            foreach (var item in x)
            {
                if (item % 2 != 0)
                {
                    y.Add(item);
                }
            }
            return 0;
        }

        static int IspisiListe(List<int> x, List<int> y)
        {
            Console.WriteLine("Uneseni parni brojevi su :");
            foreach (var item in x)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Uneseni neparni brojevi su :");
            foreach (var item in y)
            {
                Console.Write(item + " ");
            }
            return 0;

        }
    }
}
