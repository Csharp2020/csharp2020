using System;
using System.Collections.Generic;
using System.Text;

namespace _05_03_2020_AG
{
    class Student:Ucenik
    {
        public enum Spoll
        {
            male,
            female
        }

        private Spoll spol;
        public Spoll Spol
        {
            get
            {
                return spol;
            }
            set
            {
                spol = value;
            }
        }
        private string studira;
        public string Studira
        {
            get
            {
                return studira;
            }
            set
            {
                if (Prosjek == 3)
                {
                    studira = "Biologiju";
                }
                else if (Prosjek == 4)
                {
                    studira = "Informatiku";
                }
                else if (Prosjek == 5)
                {
                    studira = "Matematiku";
                }
                else
                {
                    studira = "Nista";
                }
            }
        }

        

        public int Brak()
        {
            Console.WriteLine("Jeste li u braku? Y/N");
            string odgovor = Console.ReadLine();
            if(odgovor == "Y" || odgovor == "y")
            {
                Console.WriteLine("Ukoliko imate novo prezime, molimo, unesite ga. U suprotnom, pritisnite tipku ENTER!");
                string novo_prezime = Console.ReadLine();
                if (novo_prezime != null)
                {
                    this.Prezime = novo_prezime;
                }
                if(novo_prezime == "\n")
                {
                    Console.WriteLine("Tako je, ne daj svoje prezime uzalud!");
                }
            }
            else if (odgovor == "N" || odgovor == "n")
            {
                Console.WriteLine("Odlicno, nemas vremena za brak! Samo uci, ima vremena za svatove kasnije!");
            }
            else
            {
                Console.WriteLine("Mislim da ne shvacas pitanje, nisi ti za studirati!");
            }
            return 1;

        }

        public override string ToString()
        {
            return "Student " + Ime + " " + Prezime + " rodjen " + DatumRodjenja + " prošlu akademsku godinu zavrsio je s prosjekom: " + Prosjek +
                " te sada studira " + Studira;
        }
    }
}
