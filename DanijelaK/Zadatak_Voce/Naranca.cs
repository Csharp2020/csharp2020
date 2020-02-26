namespace Zadatak_Voce
{
    internal class Naranca : Voce
    {
        private int radijus;

        public Naranca(int v)
        {
            this.radijus = v;
           
        }

        public int Radijus { get; internal set; }
    }
}