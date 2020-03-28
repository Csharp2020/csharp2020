using System;

namespace _12_1_datumi
{
    class Program
    {
        static void Main(string[] args)
        {
            //12_1_1_rodjendan

            Osoba o1 = new Osoba("Marko","Curic");
            o1.Rodjendan += new Osoba.RodjendanDelegat(Rodjendan);
            o1.DatumRodjenja = DateTime.Parse("10/17/1993");
            Console.WriteLine("Molim unesite svoj datum rodjenja!");
            DateTime dob = DateTime.Parse(Console.ReadLine());
            o1.DatumRodjenja = dob;

            Stoperica s1 = new Stoperica();
            s1.StopericaStart += new Stoperica.StopericaStartDelegat(StopericaStart);
            s1.StopericaStop += new Stoperica.StopericaStopDelegat(StopericaStop);
            Console.WriteLine("Pritisnite bilo koju tipku kako biste poceli mjeriti vrijeme!!");
            var varijabla1 = Console.ReadKey();
            if(varijabla1 != null)
            {
                s1.Pocetak = DateTime.Now;
            }
            Console.WriteLine("Pritisnite bilo koju tipku kako biste zaustavili mjerenje vremena!!");
            var varijabla2 = Console.ReadKey();
            if (varijabla2 != null)
            {
                s1.Kraj = DateTime.Now;
            }

            Console.ReadLine();
        }

        private static void Rodjendan(object sender, EventArgs e)
        {
            Console.WriteLine("Kako je {0} {1} mogao/la promjeniti datum rodjenja na {2}",
                ((Osoba)sender).Ime, ((Osoba)sender).Prezime, ((Osoba)sender).DatumRodjenja); //iz nekog razloga ne zeli ucitati ime i prezime osobe
        }

        // 12_1_2_stoperica

        private static void StopericaStart(object sender, EventArgs e)
        {
            //((Stoperica)sender).Pocetak = DateTime.Now;
            Console.WriteLine("Stoperica pokrenuta u {0}", ((Stoperica)sender).Pocetak);
        }
        private static void StopericaStop(object sender, EventArgs e)
        {
            //((Stoperica)sender).Kraj = DateTime.Now;
            Console.WriteLine("Stoperica zaustavljena u {0}", ((Stoperica)sender).Kraj);
            Console.WriteLine("Od pocetka do kraja stopanja proslo je {0} sekundi",
                ((((Stoperica)sender).Kraj)-((Stoperica)sender).Pocetak).Seconds);
        }

    }
}
