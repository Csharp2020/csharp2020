using System;

namespace naredba_switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi dane u tjednu");
            Console.WriteLine("pon u to sri cet pet sub ned");

            string dan = Console.ReadLine();

            switch (dan)
            {
                case "pon":
                case "puto":

                case "sri":
                case "cet":
                case "pet":




                case "pon": Console.WriteLine("radni dan"); break;
                case "sub":
                case "ned":
                case "sub": Console.WriteLine("vikend"); break;

                default:
                    Console.WriteLine("nepoznati dan ?!?!"); break;

            }
        }
    }
}
