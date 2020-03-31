using System;

namespace _05_03_2020_AG
{
    interface IUcenik
    {
        DateTime DatumRodjenja { get; set; }
        string Ime { get; set; }
        string Prezime { get; set; }
        double Prosjek { get; set; }

        void ProsjekRijecima();
        int Starost();
        string ToString();
    }
}