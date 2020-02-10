using System;
/**
 * kalkulator sa osnovnim operacijama + - * /
 * korisnin unosi dva broja i peraciju
 * na ekranu ispisuje rezultat
 */

namespace _5_2_2_kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            char op;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            op = char.Parse(Console.ReadLine());

            if (op == '+')
            {
                Console.WriteLine("zbroj je " + (a + b));

            }

        else if (op=='-')
            {
                Console.WriteLine("razlika je " + (a - b));

            }
            else if (op == '*')
            {
                Console.WriteLine("umnožak " + (a * b));

            }
            else if (op == '/')
            {
                Console.WriteLine("količnik " + (a / b));

            }
        }
    }
}
