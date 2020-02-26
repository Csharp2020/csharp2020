using System;
using System.Collections.Generic;
using System.Text;

namespace zadatak_voce
{
    class Apple:Fruit
    {
        double meassure;
        public double Meassure
        {
            get => meassure;
            set => meassure = value;
        }

        public Apple() { }
        public Apple(double meassure, string color = "green")
        {
            this.meassure = meassure;
            this.Color = color;
        }
    }
}
