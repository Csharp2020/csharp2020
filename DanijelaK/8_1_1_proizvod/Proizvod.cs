using System;

namespace _8_1_1_proizvod
{
    internal class Proizvod
    {
        private double cijena =0;
        private double marza= 0;
        private double porez= 0;
        private string naziv= "";

        public Proizvod(string n)
        {
            naziv = n; 
        }

        public double Cijena
        {
            get => cijena;
            set => cijena;
        }
        public double Marza
        {
            get => marza;
            set => porez;
        }
        public double Porez
        {
            get => porez;
            set => porez;
        }

        public int Naziv { get; internal set; }

        public double MPC()
        {
            return cijena + marza + porez;
        }
    }
}