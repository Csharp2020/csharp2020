using System;
using System.IO;

namespace Primjer_10_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mapa u kojoj se izvršava nas program:");
            Console.WriteLine(Environment.CurrentDirectory);

            Console.Write("Postoji li file Proba.txt u izvršnoj mapi: ");

            string mojaPutanja = Path.Combine(Environment.CurrentDirectory, "Proba.txt");
            Console.WriteLine(File.Exists(mojaPutanja));

            if(!Directory.Exists("Proba"))
            {
                Directory.CreateDirectory("Proba");
            }



            Console.WriteLine("Direktoriji na D:");
            string[] sDirs = Directory.GetDirectories(@"D:\");
            foreach  (string sDir in sDirs)
            {
                Console.WriteLine(sDir);
            }



            Console.WriteLine("Datoteke na D:");
            string[] sFiles = Directory.GetFiles(@"D:\");
            foreach (string sFile in sFiles)
            {
                Console.WriteLine(Path.GetFileName(sFile));
            }
        }
    }
}
