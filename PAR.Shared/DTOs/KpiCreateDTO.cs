using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAR.Shared.DTOs
{
    public class KpiCreateDTO
    {
        [Required]
        public string? Activity { get; set; }
        [Required]
        public string? Kpitext { get; set; }
        public string? MileStoneQtr1 { get; set; }
        public string? MileStoneQtr2 { get; set; }
        public string? MileStoneQtr3 { get; set; }
        public string? MileStoneQtr4 { get; set; }
    }
}
