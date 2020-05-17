using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Ispit.Models
{
    public class Pokloni
    {
        public int Id { get; set; }
        public string NazivPoklona { get; set; }
    
        [DataType(DataType.Currency)]
        [DisplayFormat(ApplyFormatInEditMode =true, DataFormatString ="{0:0.00}")]
        public double Iznos { get; set; }
        public bool Kupljeno { get; set; }
    }
}
