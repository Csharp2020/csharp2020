using System;

namespace _13_1_enum
{
    public enum Spol
    {
        Muski,
        Zenski,
        Ostalo
    }
    public enum Dani
    {
        Ponedjeljak,
        Utorak,
        Srijeda
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Dobar dan, vaš spol je: {Spol.Muski}, danas je {Dani.Ponedjeljak}");
        }
    }
}
