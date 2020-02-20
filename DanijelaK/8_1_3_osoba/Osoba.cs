namespace _8_1_3_osoba
{
    internal class Osoba
    {
        private string prezime;
        private string ime;

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }

        public override string ToString()
        {
            return $"{Ime} {Prezime} naš najdraži";
        }
    }
}