using System;
using System.IO;

namespace Primjer_10_1_1_Datoteke
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upišite tekst: ");
            string upisano = Console.ReadLine();

            FileStream fs1 = new FileStream("Proba.txt", FileMode.Create);

            StreamWriter sw = new StreamWriter(fs1);

            sw.WriteLine(upisano);
            sw.Flush();
            sw.Close();
            fs1.Close();

            FileStream fs2 = new FileStream("Proba.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs2);

            string procitano = sr.ReadToEnd();
            sr.Close();
            fs2.Close();

            Console.WriteLine(procitano);

        }
    }
}
