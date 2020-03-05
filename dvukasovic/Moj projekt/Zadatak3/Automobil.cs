namespace Zadatak3
{
    internal class Automobil
    {
        internal string Naziv;
        internal int GodinaProizvodnje;
        internal int OsnovnaCijena;
        public double Starost()
        {
            return 2020 - GodinaProizvodnje;
        }

        public override string ToString()
        {
            return $"Automobil naziv je {Naziv} godina proizvodnje je {GodinaProizvodnje} a osnovna cijena je {OsnovnaCijena} ";
        }

        public double UkupnaCijena()
        {
            double postotak = 0;
            if (OsnovnaCijena <= 70000 )
            {
                postotak = 1.3;
            }
            else if (OsnovnaCijena <= 100000)
            {
                postotak = 1.4;
            }
            else
            {
                postotak = 1.5;
            }
            return OsnovnaCijena * postotak;
        }
    }

    
    
}