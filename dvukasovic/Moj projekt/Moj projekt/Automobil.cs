namespace Moj_projekt
{
    class Automobil
    {
        private string markaAutomobila; // privatna varijabla, tipa string, dostupna samo vlastitoj klasi

        public string MarkaAutomobila
        {
            get => markaAutomobila;   // expression-bodied member property
            set => markaAutomobila = value;
        }
        public string MarkaAutomobila2
        {
            get
            {
                return markaAutomobila;   // Ovo je uobicajeni način
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
