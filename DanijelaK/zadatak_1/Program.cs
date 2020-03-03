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


            for (int i = 0; i < recenica.Length;i +=4)
            {
              
            }
        }
    }
}
