﻿namespace _8_2_1_doseg_varijabli
{
    internal class Tocka
    {
        private int x;
        private int y;

        public Tocka( int x,int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
    }
}