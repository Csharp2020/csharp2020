using System;

namespace zadatak_1
{
    class Program
    {
        static void Main(string[] args)
        {  // od teksta ispisi 2 po 2 znaka
            // Bio sam u zoološkom vrtu
            //biamooškrt
            Console.WriteLine("Unesite rečenicu:");
            string recenica = Console.ReadLine();
            recenica = recenica.Replace(" ", "");
            string[] r = recenica.Split();


            for (int i = 0; i < recenica.Length;i +=4)
            {
                Console.WriteLine();
            }
        }
    }
}
