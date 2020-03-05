using System;

namespace zadatak_1_naopako
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite rečenicu:");
            string recenica = Console.ReadLine();

            string obrnuto = "";
            for (int i = recenica.Length - 1; i >= 0; i--)
            {
                obrnuto += recenica[i];
            }
            Console.WriteLine(obrnuto);


        }
    }
}
