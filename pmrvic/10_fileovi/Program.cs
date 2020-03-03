using System;
using System.IO;

namespace _10_fileovi
{
    class Program
    {
        static void Main(string[] args)
        {
            //10_1_1_parni
            FileStream datoteka = new FileStream("parniii.txt", FileMode.Create);
            StreamWriter pisac = new StreamWriter(datoteka);
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    pisac.Write(i + " ");
                }
            }
            pisac.Flush();
            pisac.Close();
            datoteka.Close();

            FileStream datotekaa = new FileStream("parniii.txt", FileMode.Open);
            StreamReader citac = new StreamReader(datotekaa);
            string procitano = citac.ReadToEnd();
            Console.WriteLine(procitano);

            // kvadriraj svaki
            StreamWriter pisacbrojeva = new StreamWriter(datotekaa);
            procitano = procitano.Trim();
            string[] brojcici = procitano.Split(" ");
            foreach (var item in brojcici)
            {
                pisacbrojeva.Write(Math.Pow(int.Parse(item), 2) + " ");
              //  Console.Write(Math.Pow(int.Parse(item), 2) + " ");
            }

            Console.WriteLine("Ispis kvadrata");

            string procitajopet = citac.ReadToEnd();
            Console.WriteLine(procitajopet);
            pisacbrojeva.Flush();
            pisacbrojeva.Close();
            citac.Close();
            datotekaa.Close();



            //10_1_2_3-7
            FileStream datoteka1 = new FileStream("3or7uNoviRed.txt", FileMode.Create);
            FileStream datoteka2 = new FileStream("3or7SaZarezima.txt", FileMode.Create);
            StreamWriter pisac1 = new StreamWriter(datoteka1);
            StreamWriter pisac2 = new StreamWriter(datoteka2);
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 || i % 7 == 0)
                {
                    pisac1.Write(i+"\n");
                    pisac2.Write(i + ", ");
                }
            }
            pisac1.Flush();
            pisac1.Close();
            datoteka1.Close();
            pisac2.Flush();
            pisac2.Close();
            datoteka2.Close();

            //10_1_3_par-nepar
            FileStream datoteka3 = new FileStream("Parni.txt", FileMode.Create);
            FileStream datoteka4 = new FileStream("Neparni.txt", FileMode.Create);
            StreamWriter pisac3 = new StreamWriter(datoteka3);
            StreamWriter pisac4 = new StreamWriter(datoteka4);
            Console.WriteLine("Unosite prirodne brojeve sve dok ne unesete 0!");
            int unos;
            do
            {
                unos = int.Parse(Console.ReadLine());
                if (unos % 2 == 0)
                {
                    pisac3.Write(unos + " ");
                }
                else if (unos % 2 == 1)
                {
                    pisac4.Write(unos + " ");
                }
                else
                {
                    Console.WriteLine("Pogresan unos!! Idemo sve nanovo!!!!");
                    pisac3.Close();
                    pisac4.Close();
                    datoteka3.Close();
                    datoteka4.Close();
                    break;
                }
            } while (unos != 0);
            pisac3.Flush();
            pisac4.Flush();
            pisac3.Close();
            pisac4.Close();
            datoteka3.Close();
            datoteka4.Close();


            string pathono = @"D:\Mrvic\csharp2020\pmrvic\10_fileovi\bin\Debug\netcoreapp2.1";
            //10_1_4_Dir
            Console.WriteLine("Unesite putanju: ");
            string path = Console.ReadLine();
            string[] sDirs;
            if (Directory.Exists(@path))
            {
                sDirs = Directory.GetDirectories(@path);
                foreach (var item in sDirs)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Uneseni path nije valjan!! Pokusajte ponovo!");
            }

            //10_1_5_Directory_Info
            //Koristit cu path unesen u prethodnom zadatku, kao i sDirs iz istoga

            string[] ssDirs;
            string[] ssFiles;
            if (Directory.Exists(@path))
            {
                sDirs = Directory.GetDirectories(@path);
                Console.WriteLine($"Na unesenom pathu ima {sDirs.Length} direktorija!");
                foreach (var item in sDirs)
                {
                    if (Directory.Exists(@item))
                    {
                        ssDirs = Directory.GetDirectories(@item);
                        ssFiles = Directory.GetFiles(@item);
                        Console.WriteLine($"Direktorij {item} ima {ssDirs.Length} poddirektorija i {ssFiles.Length} datoteka!! ");
                    }
                    else
                    {
                        Console.WriteLine("Nesto je poslo po zlu, molimo probajte ponovo!");
                    }
                }
            }
            else
            {
                Console.WriteLine("Uneseni path nije valjan!! Pokusajte ponovo!");
            }


            //10_1_6_Directory_Tree
            //Koristim putanju i sve ostalo potrebno iz prijasnja dva zadatka

            Console.WriteLine("::::::::::Directory Tree::::::::::");
            if (Directory.Exists(@path))
            {
                sDirs = Directory.GetDirectories(@path);
                Console.WriteLine($"Na unesenom pathu ima {sDirs.Length} direktorija!");
                foreach (var item in sDirs)
                {
                    Console.WriteLine($":::::{item}:::::");
                    if (Directory.Exists(@item))
                    {
                        ssDirs = Directory.GetDirectories(@item);
                        foreach (var itemm in ssDirs)
                        {
                            Console.WriteLine($"{itemm}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nesto je poslo po zlu, molimo probajte ponovo!");
                    }
                }
            }
            else
            {
                Console.WriteLine("Uneseni path nije valjan!! Pokusajte ponovo!");
            }


            Console.ReadLine();
        }
    }
}
