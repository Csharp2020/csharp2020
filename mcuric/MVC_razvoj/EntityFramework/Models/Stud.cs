using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityFramework.Models
{
    public partial class Stud
    {
        public int MbrStud { get; set; }
        private string imeStud;
        public string ImeStud
        {
            get
            {
                return Lib.FirstUpper.UCFirst(imeStud);
            }
            set
            {
                imeStud = Lib.FirstUpper.UCFirst(value.Trim());
            }
        }
        private string prezStud;
        public string PrezStud
        {
            get
            {
                return Lib.FirstUpper.UCFirst(prezStud);
            }
            set
            {
                prezStud = Lib.FirstUpper.UCFirst(value.Trim());
            }
        }
        public int? PbrRod { get; set; }
        public int PbrStan { get; set; }
        [DataType(DataType.Date)]
        public DateTime? DatRodStud { get; set; }
        public string JmbgStud { get; set; }

        public virtual Mjesto PbrRodNavigation { get; set; }
        public virtual Mjesto PbrStanNavigation { get; set; }
    }
}
