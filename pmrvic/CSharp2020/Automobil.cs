using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp2020
{
    /**
     * summary Glavna tvornica
     * */
    class Automobil
    {
        private string markaAutomobila; // privatna varijabla, tipa string, dostupna samo vlastitoj klasi

        public string MarkaAutomobila {
            get => markaAutomobila;   // expression-bodied member property
            set => markaAutomobila = value;
        }
        /**
         * summary Postavljanje svojstava
         * */
        public string MarkaAutomobila2
        {
            get {
                return markaAutomobila;   // Ovo je uobicajeni način
            }
            set {
                this.markaAutomobila = value;
            }
        }

        void Kreni() { }
        void Kreni(int brzina) { }
    }
}
