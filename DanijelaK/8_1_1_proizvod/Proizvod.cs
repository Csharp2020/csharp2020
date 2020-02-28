using System;

namespace _8_1_1_proizvod
{
    internal class Proizvod
    {
        private double cijena;
        private double marza;
        private double porez;
        private string naziv;

        public double Cijena
        {
            get => cijena;
            set => cijena = value;
        }
        public double Marza
        {
            get => marza;
            set => marza = value;
        }
        public double Porez
        {
            get => porez;
            set => porez = value;
        }

        public string Naziv
        {
            get => naziv;
            set => naziv = value;
        }

        public double MPC()
        {
            return this.Cijena + this.Marza + this.Porez;
        }
    }
}