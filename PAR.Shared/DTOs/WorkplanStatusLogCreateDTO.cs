using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAR.Shared.DTOs
{
    public class WorkplanStatusLogCreateDTO
    {
        [Required]
        public int? Year { get; set; }
        [Required]
        public string? Comment { get; set; }
        [Required]
        public string? Action { get; set; }
    }
}
