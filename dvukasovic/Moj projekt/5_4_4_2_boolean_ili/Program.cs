using System;

namespace _5_4_4_2_boolean_ili
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi ime korisnika");
            string user = Console.ReadLine();
            

            if (user == "admin" || user == "root" || user =="gazda")
            {
                Console.WriteLine("Damn, provalili me!");
            }
            else
            {
                Console.WriteLine("Nećeš razbojniče");
            }
        }
    }
}
