using System;

namespace _5_2_calc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite prvi broj!");
            float prvi = float.Parse(Console.ReadLine());
            Console.WriteLine("Unesite operaciju!");
            string operacija = Console.ReadLine();
            Console.WriteLine("Unesite drugi broj");
            float drugi = float.Parse(Console.ReadLine());

            if (operacija == "+")
            {
                Console.WriteLine("Operacija zbrajanja vaših unesenih brojeva daje rezultat: {0}!!", prvi + drugi);
            }
            else if (operacija == "-")
            {
                Console.WriteLine("Operacija oduzimanja vaših unesenih brojeva daje rezultat: {0}!!", prvi - drugi);
            }
            else if (operacija == "*")
            {
                Console.WriteLine("Operacija mnozenja vaših unesenih brojeva daje rezultat: {0}!!", prvi * drugi);
            }
            else if (operacija == "/")
            {
                Console.WriteLine("Operacija dijeljenja vaših unesenih brojeva daje rezultat: {0}!!", prvi / drugi);
            }
            else
                Console.WriteLine("Niste unijeli ispravnu operaciju!!");
            Console.ReadLine();
        }
    }
}
