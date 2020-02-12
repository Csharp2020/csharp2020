using System;
using System.Collections

namespace _6._2._1
{
    class Program
    {
        static void Main(string[] args)
            //treba napisati program koji ce traziti unos 10 elemenata
            // zatim ih ispisuje naopako
        {
            Console.WriteLine("Unesite 10 elemenata");
            ArrayList arr = new ArrayList();
            for (int i = 0; i <10; i++)
            {
                arr.Add(Console.ReadLine());
            }
            ArrayList arr2 = new ArrayList();
            //arr2 = arr.Reveverse

            Console.WriteLine("Vasa originalna lista: ");
            foreach (var item in arr)
            {
                Console.WriteLine(item + " ");
            }
            arr = arr.Reverse();
            Console.WriteLine("");
            Console.WriteLine("Vasa originalna lsita okrenuta naopako");
            foreach (var item in arr)
            {
                Console.WriteLine(item + "");
            }
            Console.ReadLine
            
        }
    }
}
