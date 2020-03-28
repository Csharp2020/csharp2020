using System;

namespace celzijFahrenheit
{
    public class Celzijus
    {
        public static int c1;
        private static int zbroj;

        public Celzijus()
        {
        }

        internal static int Zbroj { get => zbroj; set => zbroj = c1*33; }
    }
}