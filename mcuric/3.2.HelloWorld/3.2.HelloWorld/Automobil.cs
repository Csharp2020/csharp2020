using System;
using System.Collections.Generic;
using System.Text;

namespace _3._2.HelloWorld
{
    class Automobil
    {
        private string markaAutomobila; // privatna varijabla tipa string, dostupna samo vlastitoj klasi

        public string MarkaAutomobila { get => markaAutomobila; set => markaAutomobila = value; }

        public string MarkaAutomobila2 { get { return markaAutomobila; } set { this.markaAutomobila = value; } }

        void Kreni() { }
        void Kreni(int brzina) { }
    }
}
