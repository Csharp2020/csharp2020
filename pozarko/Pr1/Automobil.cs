using System;
using System.Collections.Generic;
using System.Text;

namespace Pr1
{
    class Automobil
    {
        private string markaAutomobila; //privatna var, tipa string => dostupna samo vlastitoj klasi

        public string MarkaAutomobila {
            get => markaAutomobila; //expression-bodied member property
            set => markaAutomobila = value;
        }

        public string MarkaAutomobila1
        {
            get
            {
                return markaAutomobila;
            }
            set
            {
                this.markaAutomobila = value;
            }
        }

        void Kreni() { }
        void Kreni(int brzina) { }
    }
}
