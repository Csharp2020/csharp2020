using System;

namespace rijecURecenici
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite recenicu");
            string recenica = Console.ReadLine();
            string[] rijec = recenica.Split();
            Console.WriteLine("Unesite rijec koju trazimo");
            string t = Console.ReadLine();
            int counter = 0;
            for (int i = 0; i < rijec.Length; i++)
            {
                if (rijec[i] == t)
                {
                    counter++;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Broj rijeci {0} u recenici {1} je {2}", t, recenica, counter);
        }
    }
}
