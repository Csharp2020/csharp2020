using System;
using System.Collections.Generic;
using System.Text;

namespace Hello_World
{
    class Automobil
    {
       private string markaAutomobila; //privatna varijabla, tipa string, dostupna samo vlastitoj klasi

        public string MarkaAutomobila {
            get => markaAutomobila; // expression-bodied mamber property
            set => markaAutomobila = value;
        }
        public string MarkaAutomobila2
        {
            get {
                return markaAutomobila; // Ovo je uobičajni način
            }
            set {
                this.markaAutomobila = value;
            }
        }

        void Kreni() { }
        void Kreni(int brzina) {  }
    }
}
