using System;
using System.Collections;

namespace Pr._6._1._3_naopako
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();
            for (int i = 0; i < 10; i++)
            {
                arr.Add(Console.ReadLine());
            }

            ArrayList arr2 = new ArrayList();

            Console.Write("Originalna lista:");

            for(int i = 0; i < arr.Count; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine();
            arr2 = (ArrayList)arr.Clone();
            arr2.Reverse();
            Console.WriteLine("Origigi:");
            for (int i = 0; i < arr.Count; i++)
            {
                Console.Write(arr[i]+ " ");
            }
            Console.WriteLine();
            Console.WriteLine("Obrnuta:");
            for (int i = 0; i < arr2.Count; i++)
            {
                Console.Write(arr2[i]+" ");
            }

        }
    }
}
