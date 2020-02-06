using System;

namespace Prijestupna_godina
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite godinu za koju želite provjeriti dali je prijestupna ili ne");

            int god = 0;

            try
            {
                god = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Niste unjeli godinu "+ex.Message);
                Environment.Exit(0);
            }

            if (god % 400 == 0)
            {
                Console.WriteLine("Godina je prijestupna");
            }
            else if (god % 100 == 0)
            {
                Console.WriteLine("Godina nije prijestupna");
            }
            else if (god % 4 == 0)
            {
                Console.WriteLine("Godina je prijestupna");
            }
            else
            {
                Console.WriteLine("Godina nije prijestupna");
            }

        }
    }
}
