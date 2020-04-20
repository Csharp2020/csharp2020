using System;
using System.Collections.Generic;

namespace Faxi.Models
{
    public partial class VNevraceni
    {
        public string Naziv { get; set; }
        public bool Vrsta { get; set; }
        public int PrijateljiId { get; set; }
        public int MedijiId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime? DatumVracanja { get; set; }
        public DateTime DatumPosudbe { get; set; }
        public int? Dani { get; set; }
    }
}
