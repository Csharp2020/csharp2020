namespace _8_Vocarna
{
    internal class Naranca : Voce, INaranca
    {
        private double Radijus;

        public Naranca(double Radijus)
        {
            this.Radijus = Radijus;
            this.Boja = "Narančasta";
        }

        public string Kvaliteta
        {
            get
            {
                if (Radijus < 9)
                {
                    return "Nula";
                }
                else if (Radijus < 11)
                {
                    return "Tak-tak";
                }
                else
                {
                    return "Izvrsna";
                }
            }
        }

        public override string ToString()
        {
            return $"Voće, Naranča, boja:{Boja} kvaliteta:{Kvaliteta}";
        }
    }
}