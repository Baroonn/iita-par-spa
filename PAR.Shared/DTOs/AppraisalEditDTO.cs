using PAR.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAR.Shared.DTOs
{
    public class AppraisalEditDTO
    {
        public Dictionary<AppraisalScoreKey, float> Score { get; set; } = new();
        public string Comments { get; set; } = string.Empty;
        public string Strengths { get; set; } = string.Empty;
        public string Weaknesses { get; set; } = string.Empty;
        public string CompletedTraining { get; set; } = string.Empty;
        public string TrainingNeeds { get; set; } = string.Empty;
        public bool Appeal { get; set; }
        public string? StaffComments { get; set; }
        public long CountryId { get; set; }
    }
}
