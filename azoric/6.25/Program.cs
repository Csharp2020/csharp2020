using System;
using System.Collections;
namespace _6._25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("unesite prirodan broj");
            int prirodanbroj = int.Parse(Console.ReadLine());
            int faktor = 2;
            Console.WriteLine("{0} = ", prirodanbroj);

            ArrayList arr = new ArrayList();
            while (faktor <= prirodanbroj)
            {
                if (prirodanbroj % faktor == 0)
                {
                    arr.Add(faktor);
                    prirodanbroj /= faktor;
                }
                else
                {
                    faktor++;
                }

            }
            for (int i = 0; i < arr.Count; i++)
            {
                Console.WriteLine(arr[i]);
                if(i < arr.Count - 1)
                {
                    Console.WriteLine(" * ");
                }
            }
            Console.ReadKey();

        }
    }
}
