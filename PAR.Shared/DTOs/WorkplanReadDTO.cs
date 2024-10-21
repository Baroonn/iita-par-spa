using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAR.Shared.DTOs
{
    public class WorkplanReadDTO
    {
        public int Year { get; set; }
        public List<string>? Objectives { get; set; }
    }
}
