using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entity.Models
{
    public partial class Zupanija
    {
        [Key]
        public short SifZupanija { get; set; }
        public string NazZupanija { get; set; }
    }
}
