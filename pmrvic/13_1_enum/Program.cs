using System;

namespace _13_1_enum
{

    public enum Dani
    {
        Ponedjeljak=4,
        Utorak=3,
        Srijeda=5
    }
    class Program
    {
        public enum Spol
        {
            Muski,
            Zenski,
            Ostalo
        }
        static void Main(string[] args)
        {
          
        Console.WriteLine("Hello World!");

            Console.WriteLine($"DObar dan vaš spol je {Spol.Muski}, danas je{Dani.Srijeda}");
            if ((int)Dani.Srijeda == 5)
            {
                Console.WriteLine("Compare enum sa int");
            }

        }
    }
}
