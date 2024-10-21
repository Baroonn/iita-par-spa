using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAR.Shared.DTOs
{
    public class KpiReadDTO
    {
        public long Id { get; set; }

        public string? Activity { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? DateCreated { get; set; }

        public string? Kpitext { get; set; }

        public string? MileStoneQtr1 { get; set; }

        public string? MileStoneQtr2 { get; set; }

        public string? MileStoneQtr3 { get; set; }

        public string? MileStoneQtr4 { get; set; }
    }
}
