using System;

namespace _5._3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite broj");
            int suma = 0;

            for (int i = 1; i<100; i++)

            {
                suma = suma + i;
            }
            Console.WriteLine(suma);
        }
    }
}
