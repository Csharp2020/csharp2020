using System;
using System.Collections.Generic;

namespace Fakultet.Models
{
    public partial class Zupanija
    {
        string nazZupanija;
        public Zupanija()
        {
            Mjesto = new HashSet<Mjesto>();
        }

        public short SifZupanija { get; set; }
        
        
        public string NazZupanija {
            get => nazZupanija.Trim();
            set => nazZupanija = value.Trim();
        }
        

        public virtual ICollection<Mjesto> Mjesto { get; set; }
        
    }
}
