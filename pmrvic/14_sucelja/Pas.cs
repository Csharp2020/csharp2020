using System;
using System.Collections.Generic;
using System.Text;

namespace _14_sucelja
{
    class Pas : IZivotinja
    {
        private bool budan;

        public bool JelSpava()
        {
            return this.budan ? true : false;
        }

        public override string ToString()
        {
            if (this.budan)
            {
return "Ja sam budan";
            }
            else
            {
                return "Ja spavam";
            }
            
        }

        public void trci()
        {
            Console.WriteLine("trcim ");
        }

        internal void budise()
        {
            this.budan = true;
        }
    }
}
