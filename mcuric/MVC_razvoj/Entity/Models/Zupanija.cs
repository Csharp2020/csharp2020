using System;
using System.Collections.Generic;

namespace Entity.Models
{
    public partial class Zupanija
    {
        public Zupanija()
        {
            Mjesto = new HashSet<Mjesto>();
        }

        public short SifZupanija { get; set; }
        public string NazZupanija { get; set; }

        public virtual ICollection<Mjesto> Mjesto { get; set; }
    }
}
