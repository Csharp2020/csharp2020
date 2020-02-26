namespace Zadatak_Voce
{
    internal class Banana : Voce
    {
        public Banana(int v)
        {
            this.Duljina = v; 
        }

        public int Duljina { get; internal set; }
    }
}