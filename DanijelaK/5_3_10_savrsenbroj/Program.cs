using System;

namespace _5_3_10_savrsenbroj
{
    class Program
    {
        static void Main(string[] args)
        {
            // Savršeni broj je broj koji je jednak zbroju svih djelitelja (bez sebe samoga)
            Console.WriteLine("Unesite prirodan broj (savršen broj):");
            int b = int.Parse(Console.ReadLine());
            int zbroj = 0;

            for (int i = 1; i < b; i++)
            {
                if (b % i == 0)
                {
                    zbroj += i;
                }
            }
            if (b == zbroj)
            {
                Console.WriteLine("Broj je savršen!");
            }
            else
            {
                Console.WriteLine("Broj nije savršen!");
            }

            Console.WriteLine();
        }
    }
}
