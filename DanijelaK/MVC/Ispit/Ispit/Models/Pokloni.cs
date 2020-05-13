using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ispit.Models
{
    public class Pokloni
    {
        public int Id { get; set; }
        public string NazivPoklona { get; set; }

        public int Iznos { get; set; }
        public bool Kupljeno { get; set; }
    }
}
