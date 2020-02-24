using System;

namespace _8_2_doseg_vars
{
    internal class Crta
    {
        private Tocka tocka1;
        private Tocka tocka2;

        public Crta(Tocka tocka1, Tocka tocka2)
        {
            this.tocka1 = tocka1;
            this.tocka2 = tocka2;
        }

        public double Duljina
        {
            get => MojStatic.UdaljenostTocaka(tocka1,tocka2);
            //  get => Math.Sqrt(Math.Pow(tocka1.X - tocka2.X, 2) + Math.Pow(tocka1.Y - tocka2.Y, 2));
        }
    }
}