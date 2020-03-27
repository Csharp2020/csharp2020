using System;

namespace Znak_u_rijeci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite jednu riječ");
            string rijec = Console.ReadLine();
            Console.WriteLine("Unesite slovo koje cemo provjeriti u rijeci");
            char slovo = Console.ReadKey().KeyChar;

            int brojCharova = 0;

            for (int i = 0; i < rijec.Length; i++)
            {
                if (rijec[i] == slovo)
                {
                    brojCharova++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Broj slova {2} u rijeci {0} je {1}", rijec, brojCharova, slovo);
        }
    }
}
