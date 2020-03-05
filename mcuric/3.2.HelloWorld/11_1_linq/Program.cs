using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _11_1_linq
{
    class Program
    {
        static void Main(string[] args)
        {
            //11_1_1_imena

            Console.WriteLine("Unesite imena sve dok ne upisete rijec kraj!");
            List<string> imena = new List<string>();
            string ime = "";
            do
            {
                ime = Console.ReadLine();
                if (ime != "kraj")
                {
                    imena.Add(ime);
                }
                else
                {
                    Console.WriteLine("Kraj vašeg unosa!");
                }
            } while (ime != "kraj");

            List<string> imenaKojaSadrzeA = (from im in imena
                                             where im.Contains("a") || im.Contains("A")
                                             select im).ToList();
            foreach (var item in imenaKojaSadrzeA)
            {
                Console.Write(item + " ");
            }

            //11_1_2_prvi_direktorij

            Console.WriteLine("Unesite path do datoteke!");
            string path = Console.ReadLine();

            string[] sDir = Directory.GetDirectories(@path);

            string firstDir = (from dir in sDir
                               orderby sDir ascending
                               select dir).FirstOrDefault();

            string [] dvadir = (from dir in sDir
                               orderby sDir ascending
                               select dir).Take(2).ToArray();
            
            foreach (var item in dvadir)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Prvi direktorij na ovom pathu, abecedno određen je {firstDir}");

            //11_1_3_automobili

            string answer = "d";
            List<Automobil> automobili = new List<Automobil>();
            while(answer == "d" || answer == "D")
            {
                Console.WriteLine("Unesite marku automobila!");
                string marka = Console.ReadLine();
                Console.WriteLine("Unesite model automobila!");
                string model = Console.ReadLine();
                Console.WriteLine("Unesite zapreminu automobila!");
                int zapremina = int.Parse(Console.ReadLine());
                Automobil a = new Automobil(marka,model,zapremina);
                /*
                a.Marka = marka;
                a.Model = model;
                a.Zapremina = zapremina;
                */
                automobili.Add(a);
                Console.WriteLine("Želite li unijeti novi automobil?");
                answer = Console.ReadLine();
            }

            List<Automobil> listaAutomobila = (from auto in automobili
                                         orderby auto.Marka ascending
                                         where auto.Zapremina >= 1600 && auto.Zapremina < 2000
                                         select auto).ToList();
            Console.WriteLine("Abecedno poredana lista automobila s vise od 1600ccm a manje od 2k:::");
            foreach (var item in listaAutomobila)
            {
                Console.WriteLine($"{item.Marka} {item.Model} {item.Zapremina}ccm");
            }

            Console.WriteLine("Unosite brojeve sve dok ne unesete 0!");
            List<double> brojevi = new List<double>();
            double uneseniBroj = 1;
            while (uneseniBroj != 0)
            {
                uneseniBroj = double.Parse(Console.ReadLine());
                brojevi.Add(uneseniBroj);
            }
            List<double> parniBrojevi = (from broj in brojevi
                                         where broj%2==0
                                         select broj).ToList();
            List<double> neparniBrojevi = (from broj in brojevi
                                         where broj % 2 == 1
                                         select broj).ToList();
            Console.WriteLine($"Broj unesenih parnih brojeva iznosi {parniBrojevi.Count - 1}, a neparnih {neparniBrojevi.Count}");

            Console.ReadLine();
        }
    }
}
