using System;
using System.Collections.Generic;
using System.Text;

namespace _8._1._1_Proizvod
{
    class Proizvod
    {
        private string naziv;
        private double cijena;
        private double marza;
        private double porez;
        public string Naziv { 
            get => naziv; 
            set => naziv = value; 
        }
        public double Cijena { 
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
            set => porez = value*Cijena;
        }

        public double MPC()
        {
            return this.Porez + this.Marza + this.Cijena;
        }

        
    }
}
