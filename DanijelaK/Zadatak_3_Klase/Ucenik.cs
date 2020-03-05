using System;

namespace Zadatak_3_Klase
{
    internal class Ucenik
    {
        private DateTime starost;
        
        public string Ime { get;  set; }
        public string Prezime { get;  set; }
        public DateTime DatumRodjenja { get;  set; }
        public double Prosjek { get;  set; }

        public int Starost()
        {
            DateTime trenutnidatum = DateTime.Now;
            TimeSpan TS = trenutnidatum -DatumRodjenja;
            return TS.Days / 365;
        }

        public string ProsjekRijecima()
        {
            string prosjek_r = "";

            switch (Math.Round(Prosjek, 0))
            {
                case 1:
                    prosjek_r = "nedovoljan";
                    break;
                case 2:
                    prosjek_r = "dovoljan";
                    break;
                case 3:
                    prosjek_r = "dobar";
                    break;
                case 4:
                    prosjek_r = "vrlo dobar";
                    break;
                case 5:
                    prosjek_r = "odličan";
                    break;

                default:
                    prosjek_r = "nepoznata ocjena";
                    break;
            }
            return prosjek_r;
        }

        public override string ToString()
        {
            string rijec = "";
            rijec= $"Učenik se zove {Ime} {Prezime}";
            rijec +=$", rođen je {DatumRodjenja: dd / MM / yyyy}, ";
            rijec += $" ima {Starost()} godina";
            rijec += $", prosjek ocjene je: {ProsjekRijecima()}";
            return rijec;
        }
    }
}