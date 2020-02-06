using System;

namespace Pr4._2_user_pass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi ime korisnika");
            string user = Console.ReadLine();
            Console.WriteLine("Unesi password");
            string pass = Console.ReadLine();

            if (user == "Admin" && pass == "123")
            {
                Console.WriteLine("Damn provalili me!");
            }
            else
            {
                Console.WriteLine("Neces razbojnice!");
            }
        }
    }
}
