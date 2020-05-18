using System;

namespace vjezba_klasa
{
    public class Automobil
    {
        private int godinaproizvodnje;
        public delegate void NaPromjenuGodineProizvodnjeDelegat(object sender, EventArgs e);
        public event NaPromjenuGodineProizvodnjeDelegat NaPromjenuGodineProizvodnje;

        public int GodinaProizvodnja {

            get {
                return godinaproizvodnje;
            }
            
            set
            {
                godinaproizvodnje = value;
                if (NaPromjenuGodineProizvodnje != null)
                {
                    NaPromjenuGodineProizvodnje(this, new EventArgs());
                }
            }
        }

        public string Naziv { get;  set; }
        public double OsnovnaCijena { get;  set; }
        public int Starost()
        {

            return DateTime.Now.Year - GodinaProizvodnja;

        }

        public double UkupnaCijena()
        {
            if (OsnovnaCijena <= 70000)
            {
                return OsnovnaCijena * 1.3;
            }
            else if (OsnovnaCijena < 100000 && OsnovnaCijena > 70000)
            {
                return OsnovnaCijena * 1.4;
            }

            return OsnovnaCijena * 1.5;

        }
    }
}