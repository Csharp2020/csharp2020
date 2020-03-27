using System;
using System.Collections;

namespace Naopako_Liste
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista ispis naopako");
            int x = 0;
            ArrayList lista = new ArrayList();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Unesi {0} elemnt niza: ", i);
                x = int.Parse(Console.ReadLine());
                lista.Add(x);
            }
            Console.WriteLine("Lista naopako je:");

            for (int i = lista.Count-1; i >= 0; i--)
            {
                
                Console.WriteLine(lista[i]);
            }
        }
    }
}
