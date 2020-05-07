using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlgebraWebAPI2020.Models
{
    public class TodoItem
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
