using System;
using System.IO;

namespace _10_1_1_Parni
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Parni");

            FileStream fs = new FileStream("Parni.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);

            for (int i = 2; i <= 100; i += 2)
            {
                sw.WriteLine(i);
            }
            sw.Flush();
            sw.Close();
            fs.Close();

            fs = new FileStream("Parni.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string procitaj = sr.ReadToEnd();
            fs.Close();
            Console.WriteLine(procitaj);
            




        }
    }
}
