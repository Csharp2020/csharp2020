using System;
using System.Collections.Generic;
using System.Text;

namespace nekoVoce
{
    class Apple:Voce
    {
        private double radijus;

        public double RadijusJ
        {
            get => radijus;
            set => radijus = 2;
        }

        public double opseg()
        {
            return RadijusJ * Math.PI * 2;
        }
    }
}
