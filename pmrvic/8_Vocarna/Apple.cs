using System;

namespace _8_Vocarna
{
    internal class Apple:Voce
    {
        public static int kolikopromjena;
        private double tezina;
        public delegate void del_promjena_tezine(object sender, EventArgs e);
        public event del_promjena_tezine PromjenaTezine;
        
        public double Tezina
        {
            get => tezina;
            set
            {
                PromjenaTezine?.Invoke(this, new EventArgs());
                this.tezina = value;
            }
        }

    public Apple(double Tezina)
        {
            this.Tezina = Tezina;
            Random r = new Random();
            switch(r.Next(1, 3))
            {
                case 1:this.Boja = "Zelena";break;
                case 2: this.Boja = "Žuta"; break;
                case 3: this.Boja = "Crvena"; break;
            }


        }
    }
}