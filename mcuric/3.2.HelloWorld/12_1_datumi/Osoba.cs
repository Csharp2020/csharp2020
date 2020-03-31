using System;
using System.Collections.Generic;
using System.Text;

namespace _12_1_datumi
{
    class Osoba
    {
        public delegate void RodjendanDelegat(object sender, EventArgs e);
        public event RodjendanDelegat Rodjendan;

        string ime;
        public string Ime { get; set; }
        string prezime;
        public string Prezime { get; set; }
        DateTime datumrodjenja;
        public DateTime DatumRodjenja
        {
            get
            {
                return datumrodjenja;
            }
            set
            {
                datumrodjenja = value;
                if (Rodjendan != null)
                {
                    Rodjendan(this, new EventArgs());
                }
            }
        }
        int starost;
        public int Starost { get
            {
                return (int)(((DateTime.Now - datumrodjenja).Days) / 365.25);
            } }
        enum Spol
        {
            male,
            female
        }

        public Osoba(string ime, string prezime)
        {
            this.ime = ime;
            this.prezime = prezime;
        }




    }
}
