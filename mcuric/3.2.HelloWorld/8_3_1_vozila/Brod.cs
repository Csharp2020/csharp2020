using System;
using System.Collections.Generic;
using System.Text;

namespace _8_3_1_vozila
{
    class Brod:Vozilo
    {
        double istisna;

        public double Istisna { get => istisna;
            set
            {
                this.istisna = value;
                if(NaPromjenuIstisne != null)
                {
                    NaPromjenuIstisne(this, new EventArgs());
                }
            }
        }

        public delegate void NaPromjenuIstinseDelegat(object sender, EventArgs e);
        public event NaPromjenuIstinseDelegat NaPromjenuIstisne;
    }
}
