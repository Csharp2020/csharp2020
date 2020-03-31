using System;
using System.Collections;

namespace liste_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sortiranje liste");
            int x = -1;
            ArrayList lista = new ArrayList();

            while (x !=0)
            {
                x = int.Parse(Console.ReadLine());
                lista.Add(x);
            }
            lista.Sort();

            Console.WriteLine("Brojevi u listi su ");
            for (int i = 0; i < lista.Count; i++)
            {

                Console.WriteLine(lista[i]);
            }
        }
    }
}
