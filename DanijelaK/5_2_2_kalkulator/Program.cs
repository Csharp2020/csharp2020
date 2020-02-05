using System;
/**
 * kalkulator sa osnovnim operacijama + - * /
 * korisnik unosi 2 broja i operaciju 
 * na ekranu ispisuje rezultat
 **/
namespace _5_2_2_kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite broj");
            float a = float.Parse(Console.ReadLine());

            Console.WriteLine("Unesite broj");
            float b = float.Parse(Console.ReadLine());

            Console.WriteLine("Odaberite računsku operaciju +, -, * ili /");
                char c = char.Parse(Console.ReadLine());


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

        }
    }
}
