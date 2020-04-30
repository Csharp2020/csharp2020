using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityFramework.Models
{
    public partial class Pred
    {
        public int SifPred { get; set; }
        [Display(Name = "Kratica")]
        public string KratPred { get; set; }
        [Display(Name = "Naziv predmeta")]
        public string NazPred { get; set; }
        public int? SifOrgjed { get; set; }
        [Display(Name = "Upisano studenata")]
        public int? UpisanoStud { get; set; }
        [Display(Name = "Tjedni fond sati")]
        public int? BrojSatiTjedno { get; set; }

        [Display(Name = "Organizacijska jedinica")]
        public virtual Orgjed SifOrgjedNavigation { get; set; }
        public ICollection<PredNastavnik> PredNastavnik { get; set; }
    }
}
