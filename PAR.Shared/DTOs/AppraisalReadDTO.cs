using PAR.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAR.Shared.DTOs
{
    public class AppraisalReadDTO
    {
        public long Id { get; set; }
        public string Unit { get; set; } = string.Empty;
        public string Project { get; set; } = string.Empty;
        public string AppraiseeName { get; set; } = string.Empty;
        public string AppraiserName { get; set; } = string.Empty;
        public string JobTitle { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string Supervisor { get; set; } = string.Empty;
        public DateTime? LastUpdated { get; set; }
        public string? LastUpdatedBy { get; set; }
        public string Status { get; set; } = string.Empty;
        public string RatingSummary { get; set; } = string.Empty;
        public double FinalScore { get; set; }
        public Dictionary<AppraisalScoreKey, float> Score { get; set; } = [];
        public string Comments { get; set; } = string.Empty;
        public string Strengths { get; set; } = string.Empty;
        public string Weaknesses { get; set; } = string.Empty;
        public string CompletedTraining { get; set; } = string.Empty;
        public string TrainingNeeds { get; set; } = string.Empty;
        public bool AppraiseeServed { get; set; }
        public bool Appeal { get; set; }
        public string StaffComments { get; set; } = string.Empty;
    }
}
