using System;

namespace _5_4_4_2_boolean_ili
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi ime korisnika");
            string user = Console.ReadLine();
            Console.WriteLine("Unesi password");
            string pass = Console.ReadLine();

            if (user == "admin" || user == "root" || user == "gazda") // (true) ILI (true) ILI (true) = (true)

            {
                Console.WriteLine("Dobrodosli direktore");
            }
            else
            {
                Console.WriteLine("Nećeš razbojniče jedan");
            }
        }
    }
}
