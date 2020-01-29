using System;
using System.Collections.Generic;
using System.Text;

namespace Uvod
{
    class Automobil
    {
        private string markaAutomobila; // privatna varijabla , tuoa string , dostupna samo vlastitoj klasi

        public string MarkaAutomobila {
            get => markaAutomobila;     // expression bodied member property
            set => markaAutomobila = value; }

        public string MarkaAutomobila2
        {
            get
            {
                return markaAutomobila;   // obican nacin
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
