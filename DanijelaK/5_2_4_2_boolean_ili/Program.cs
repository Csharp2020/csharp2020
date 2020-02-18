using System;

namespace _5_2_4_2_boolean_ili
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("unesi ime korisnika");
            string user = Console.ReadLine();
           

            if (user == "admin" || user == "root" || user == "gazda") // (true) ILI (true) ILI (true) = (TRUE)
            {
                Console.WriteLine("Dobrološli direktore");
            }
            else
            {
                Console.WriteLine("Nećeš razbojniče!");
            }
        }
    }
}
