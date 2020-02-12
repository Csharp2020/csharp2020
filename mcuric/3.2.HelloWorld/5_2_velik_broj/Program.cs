using System;

namespace _5_2_velik_broj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite broj!");
            string broj = Console.ReadLine();
            broj = broj.Replace(",", "");  //3,157 prebacuje u 3157
            if (broj.Length >= 3)
            {
                Console.WriteLine("BROJ JE VELIK!!!");
            }
            else
                Console.WriteLine("Broj je mali..");
            Console.ReadLine();

            int n = 0;
            int br = int.Parse(broj);

            Console.WriteLine("Broj je {0}", br);

            while (br > 1)
            {
                br /= 10;
                n ++;
            }
            if (n >= 3)
            {
                Console.WriteLine("BROJ JE VELIK!!");
            }
            else
                Console.WriteLine("Broj je mali..");
            Console.ReadLine();
        }
    }
}
