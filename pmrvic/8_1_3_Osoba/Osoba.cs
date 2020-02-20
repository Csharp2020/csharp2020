namespace _8_1_3_Osoba
{
    internal class Osoba
    {
        private string prezime;
        private string ime;

        public string Ime {
            get => ime;
            set => ime = Slova.PrvoVeliko(value);
    }
        public string Prezime {
            get => prezime;
            set => prezime = Slova.PrvoVeliko(value);
        }

        public override string ToString()
        {
            return $"{Ime} {Prezime} naš najdraži";
        }
    }
}