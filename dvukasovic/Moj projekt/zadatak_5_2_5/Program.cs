using System;

namespace zadatak_5_2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bilo koji broj znamenki");

            string broj = Console.ReadLine();

            broj = broj.Replace("-", ""); // -3,14 postaje 3,14
            broj = broj.Replace(",", ""); // 3,14 postaje 314


            if (broj.Length >= 3)
            {
                Console.WriteLine("Broj je velik");
            }
            else
            {
                Console.WriteLine("Broj nije velik");
            }

            int n = 0;  // brojac znamenki
            int br = int.Parse(broj);

            while (br <= 1) // mala greska kod ovoga jer ako unesemo 1, 1 nece uci u petlju (slucajno ce biti tocan)
            {
                br /= 10; // broj=broj /10
                n++;
            }
            if (n >= 3)
            {
                Console.WriteLine("2.način: Broj je velik");
            }
            else
            {
                Console.WriteLine("2.način: Broj nije velik");
            }
        }
    }
}
