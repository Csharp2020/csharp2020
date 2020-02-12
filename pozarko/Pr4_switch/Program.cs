using System;

namespace Pr4_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi dan u tjednu");
            Console.WriteLine("pon uto sri cet pet sub ned");

            string dan = Console.ReadLine();

            switch (dan)
            {
                case "pon":
                case "uto":
                case "sri":
                case "cet":
                case "pet":
                    Console.WriteLine("radni dan"); break;
                case "sub":
                case "ned":
                    Console.WriteLine("vikend"); break;
                default: Console.WriteLine("Nepoznati dan"); break;
            }
        }
    }
}
