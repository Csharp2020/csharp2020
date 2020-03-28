using System;

namespace _5_2_4_1_user_pass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi ime korisnika");
            string user = Console.ReadLine();
            Console.WriteLine("Unesi password");
            string pass = Console.ReadLine();

            if (user== "admin" && pass=="123")
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
