using System;

namespace _8_2_2_1_Ref
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prijenos po ref.");

            int x = 1;
            Console.WriteLine($"x: {x}");

            povecaj_prvi(x); // proslijedili po vrijednosti
            Console.WriteLine("nakon povecanja");
            Console.WriteLine($"x: {x}");

            povecaj_drugi(ref x); // pros. po referenci
            Console.WriteLine("nakon povecanja(ref)");
            Console.WriteLine($"x: {x}");
        }

        private static void povecaj_drugi(ref int broj)
        {
            broj++;
        }

        private static void povecaj_prvi(int broj)
        {
            broj++;
        }
    }
}
