using System;

namespace _5_2_2_danUTjednu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi dan u tjednu!");
            Console.WriteLine("pon uto sri cet pet sub ned");

            string dan = Console.ReadLine();

            switch (dan)
            {
                case "pon": Console.WriteLine("Radni dan"); break;
                case "uto": Console.WriteLine("Radni dan"); break;
                case "sri": Console.WriteLine("Radni dan"); break;
                case "cet": Console.WriteLine("Radni dan"); break;
                case "pet": Console.WriteLine("Radni dan"); break;
                case "sub": Console.WriteLine("Vikend"); break;
                case "ned": Console.WriteLine("Vikend"); break;
                default:
                    Console.WriteLine("nepoznat dan");
                    break;
            }
        }
    }
}
