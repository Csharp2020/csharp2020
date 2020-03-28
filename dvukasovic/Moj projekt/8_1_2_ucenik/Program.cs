using System;

namespace _8_1_2_ucenik
{
    class Program
    {
        static void Main(string[] args)
        {
            Ucenik u1 = new Ucenik();
            Console.WriteLine("Unesti ime ucenika");
            u1.Ime = Console.ReadLine();
            Console.WriteLine("Ucenikovo ime je: " + u1.Ime);
        }
    }
}
