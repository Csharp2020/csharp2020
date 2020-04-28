using System;
using System.Collections.Generic;

namespace Fakultet.Models
{
    public partial class Pred
    {
        public int SifPred { get; set; }
        public string KratPred { get; set; }
        public string NazPred { get; set; }
        public int? SifOrgjed { get; set; }
        public int? UpisanoStud { get; set; }
        public int? BrojSatiTjedno { get; set; }

        public virtual Orgjed SifOrgjedNavigation { get; set; }

    }
}
