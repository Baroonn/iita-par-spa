using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAR.Shared.DTOs
{
    public class ActivityReadDTO
    {
        public int? EntryYear { get; set; }
        public int? ActivityYear { get; set; }
        public string? NextYearGoals { get; set; }
        public string? ResponsibilityChanges { get; set; }
        public string? ResponsibilityOutputs { get; set; }
        public string? SuccessAndChallenges { get; set; }
        public string? AdditionalSuggestions { get; set; }
    }
}
