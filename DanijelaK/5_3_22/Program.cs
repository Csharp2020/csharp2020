using System;

namespace _5_3_22
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean opet = true;
            do
            {

                Console.WriteLine("Unesite broj");
                float a = float.Parse(Console.ReadLine());

                Console.WriteLine("Odaberite računsku operaciju +, -, * ili /");
                char c = char.Parse(Console.ReadLine());

                Console.WriteLine("Unesite broj");
                float b = float.Parse(Console.ReadLine());

                if (c == '+')
                {
                    Console.WriteLine(a + b);
                }
                else if (c == '-')
                {
                    Console.WriteLine(a - b);
                }
                else if (c == '*')
                {
                    Console.WriteLine(a * b);
                }
                else if (c == '/')
                {
                    Console.WriteLine(a / b);
                }
                else
                {
                    Console.WriteLine("Nepoznata računska operacija");
                }

                Console.WriteLine("Želite li računati opet? (D/N)");
                string unos = Console.ReadLine();

                if (unos=="D" || unos == "d")
                {
                    opet = true;
                }
                else
                {
                    opet = false;
                }

            } while (opet);
        }
    }
}
