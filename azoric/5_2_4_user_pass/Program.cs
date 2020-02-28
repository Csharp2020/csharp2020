using System;

namespace _5_2_4_user_pass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi ime korisnika");
            string user = Console.ReadLine();
            Console.WriteLine("Unesi password");
            string pass = Console.ReadLine();

              if(user == "admin" && pass == "123") // (true) && (true) = (true)

            {
                Console.WriteLine("Damn, provaljen sam");
            }
            else
            {
                Console.WriteLine("Nećeš razbojniče jedan");


            }
        }
    }
}
