using System;

namespace _8_1_3_Zaposlenik
{
    class Program
    {
        static void Main(string[] args)
        {
            Zaposlenik dominik = new Zaposlenik("Dominik","Dodic");
            dominik.brojBodova = 500;
            dominik.vrijednostBoda = 80;
            Console.WriteLine($"Bruto izracun place za osobu {dominik.ime} {dominik.prezime} : {dominik.BrutoIzracunPlace()}," +
                $"Neto izracun place za osobu {dominik.ime} {dominik.prezime} : {dominik.NetoIzracunPlace()} ");
            Console.ReadLine();
        }
    }
}
