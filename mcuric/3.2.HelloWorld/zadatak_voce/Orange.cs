using System;
using System.Collections.Generic;
using System.Text;

namespace zadatak_voce
{
    class Orange:Fruit
    {
        double radius;
        public double Radius
        {
            get => radius;
            set => radius = value;
        }

        public Orange() { }
        public Orange(double radius, string color = "orange")
        {
            this.radius = radius;
            this.Color = color;
        }
    }
}
