using System;
using System.Collections.Generic;

namespace Firma.Models
{
    public partial class Rezervacija
    {
        public string OznDvorana { get; set; }
        public string OznVrstaDan { get; set; }
        public short Sat { get; set; }
        public int SifPred { get; set; }
    }
}
