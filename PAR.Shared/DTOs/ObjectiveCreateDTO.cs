using PAR.Shared.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAR.Shared.DTOs
{
    public class ObjectiveCreateDTO
    {
        [Required]
        public string? Objective { get; set; }
        public int Status { get; set; } = (int)WorkplanStatus.Draft;
        [Required]
        public int? Year { get; set; }
    }
}
