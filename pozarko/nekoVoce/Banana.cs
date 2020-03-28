using System;
using System.Collections.Generic;
using System.Text;

namespace nekoVoce
{
    class Banana:Voce
    {
        private int duljina;

        public int Duljina { 
            get => duljina; 
            set => duljina = 3; 
        }

        public override string ToString()
        {
            return $"Voće: banana, duljina {Duljina}";
        }
    }
}
