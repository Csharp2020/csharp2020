using System;
using System.Collections.Generic;

namespace Faxi.Models
{
    public partial class Evidencije
    {
        public int PrijateljiId { get; set; }
        public int MedijiId { get; set; }
        public DateTime DatumPosudbe { get; set; }
        public DateTime? DatumVracanja { get; set; }

        public virtual Mediji Mediji { get; set; }
        public virtual Prijatelji Prijatelji { get; set; }
    }
}
