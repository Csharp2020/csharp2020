using System;


/**
 * kalkulator sa osnovnim operacijama + - * /
 * korisnik unosi 2 broja i operaciju
 * na ekranu se ispisuje rezultat i sve poruke 
 * */
namespace _5._2._2_kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi prvi broj");
            float br1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Unesi drugi broj");
            float br2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Unesi operater: \n+ , -, * ili /");
            char op = char.Parse(Console.ReadLine());
            if ( op == '+')
            {
                Console.WriteLine("Riješenje je " + (br1 + br2));
            }
            else
            {
                if ( op == '-')
                {
                    Console.WriteLine("Riješenje je " + (br1 - br2));
                }
                else
                {
                    if ( op == '*')

                    {
                        Console.WriteLine("Riješenje je " + (br1 * br2));
                    }

                    else
                    {
                        if ( op == '/')
                        {
                            Console.WriteLine("Riješenje je " + (br1 / br2));
                        }
                    }
                }


            }
        }

    }
}
