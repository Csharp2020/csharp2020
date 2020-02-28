namespace _8_Vocarna
{
    internal class Banana:Voce
    {
        private int Duljina;

        public Banana(int Duljina)
        {
            this.Duljina = Duljina;
            this.Boja = "Žuta";
        }

        public bool Trula { get; internal set; }

        public override string ToString()
        {
            return $"Voće: banana, duljina {Duljina}";
        }
    }
}