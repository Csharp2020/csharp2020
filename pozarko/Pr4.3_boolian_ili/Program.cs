using System;

namespace Pr4._3_boolian_ili
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi ime korisnika");
            string user = Console.ReadLine();;

            if (user == "Admin" || user == "123")
            {
                Console.WriteLine("Dobrodosli direktore!");
            }
            else
            {
                Console.WriteLine("Neces razbojnice!");
            }
        }
    }
}
