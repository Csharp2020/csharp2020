using System;

namespace Suma_100_brojeva
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int suma = 0;
            for (int i = 0; i <= 100; i++)
            {
                suma += i;
            }
            Console.WriteLine("Suma prvih 100 brojeva je {0}", suma);
        }
    }
}
