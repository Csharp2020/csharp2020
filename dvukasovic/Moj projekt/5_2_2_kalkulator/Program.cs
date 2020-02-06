using System;

namespace _5_2_2_kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite prirodan broj");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Unesite prirodan broj");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Zelite li +, -, * ili / ?");
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
                Console.WriteLine("Nepoznata računska opreacija");
            }

        }
    }
}
