using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAR.Shared.DTOs
{
    public class WorkplanStatusLogReadDTO
    {
        public string? Action { get; set; }
        public string? Comment { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
