using System;

namespace _8._1._3_Zaposlenik
{
    class Program
    {
        static void Main(string[] args)
        {
            zapo();
        }

        static void zapo()
        {
            string x, y;
            int z;
            Console.WriteLine("Ime:");
            x = Console.ReadLine();
            Console.WriteLine("Prezime:");
            y = Console.ReadLine();
            Console.WriteLine("JMBG:");
            z = int.Parse(Console.ReadLine());
            Zaposlenik zap = new Zaposlenik(x, y, z);
            Console.WriteLine("Broj bodova:");
            zap.BrojBodova = int.Parse(Console.ReadLine());
            Console.WriteLine("Vrijednost boda:");
            zap.VrijednostBoda = int.Parse(Console.ReadLine());
        }
    }
}
