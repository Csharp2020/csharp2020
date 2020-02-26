using System;
using System.Collections.Generic;
using System.Text;

namespace zadatak_voce
{
    class Banana:Fruit
    {
        double length;
        public double Length
        {
            get => length;
            set => length = value;
        }

        public Banana() { }
        public Banana(double length, string color = "yellow") {
            this.length = length;
            this.Color = color; 
        }
    }
}
