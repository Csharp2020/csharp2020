using System;

namespace _5_2_4_1_user_pass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("unesi ime korisnika");
            string user = Console.ReadLine();
            Console.WriteLine("unesi password");
            string pass = Console.ReadLine();

            if (user=="admin" && pass =="123") // (true) && (true) = (true)
            {
                Console.WriteLine("Damn, provalili me");
            }
            else
            {
                Console.WriteLine("Nećeš razbojniče!");
            }
        }
    }
}
