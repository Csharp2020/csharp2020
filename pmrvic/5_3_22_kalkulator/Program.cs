/**
 * dopuni kalkulator, neka pita želite li ponovo (D/N)
 * dok je potvrdan trazi ponovo dva broja i unos operacije
 * 
 * */

using System;

namespace _5_3_22_kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean opet = true;
            do
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
            {
                Console.WriteLine("Niste unijeli ispravnu operaciju!!");
            }

                Console.WriteLine("Želite li računati opet? (D/N)");
                string unos = Console.ReadLine(); //

                if (unos == "D" || unos == "d")
                {
                    opet = true;
                }
                else
                {
                    opet = false;
                }

            }
            while (opet);

        }
    }
}
