namespace _8_3_1_vozila
{
    internal class Automobil : Vozilo
    {
        public Automobil()
        {
        }

        public Automobil(string Naziv, string Boja, int KS)
        {
            this.Naziv = Naziv;
            this.Boja = Boja;
            this.KS = KS;
        }

        public override string ToString()
        {
            return $"Automobil {Naziv}, {KS}"; 
        }
    }
}