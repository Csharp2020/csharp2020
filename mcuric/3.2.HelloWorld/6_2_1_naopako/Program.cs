using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _6_2_1_naopako
{
    class Program
    {
        static void Main(string[] args)
        {
            //treba napisati program koji ce traziti unos 10 elemenata
            //zatim ih ispisuje naopako
            Console.WriteLine("Unesite 10 elemenata!");
            ArrayList arr = new ArrayList();
            for (int i = 0; i < 10; i++)
            {
                arr.Add(Console.ReadLine());
            }
            ArrayList arr2 = new ArrayList();
            //arr2 = arr.Reverse

            Console.WriteLine("Vaša originalna lista: ");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            arr.Reverse();
            Console.WriteLine("");
            Console.WriteLine("Vaša originalna lista okrenuta naopako: ");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.ReadLine();
        }
    }
}
