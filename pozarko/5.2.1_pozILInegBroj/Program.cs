using System;

namespace _5._2._1_pozILInegBroj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite broj: ");
            int i = int.Parse(Console.ReadLine());

            if (i > 0) //Ako je veci od 0
            {
                Console.WriteLine("Broj je veci od nule");
            }
            else if (i < 0) //Ako je manji od 0
            {
                Console.WriteLine("Broj je manji od nule");
            }
            else //Ako je jednak nuli
            {
                Console.WriteLine("Broj je jednak nuli");
            }
        }
    }
}
