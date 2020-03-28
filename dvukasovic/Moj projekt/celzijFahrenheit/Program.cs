using System;

namespace celzijFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Celzij");
            Celzijus c1 = new Celzijus();

            Console.WriteLine("Unesi celzije:");
            Celzijus.c1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Celzijusa si unio {0} a konverzija u farentheith je {1}", Celzijus.c1, Celzijus.Zbroj);
        }
    }
}
