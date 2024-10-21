namespace PAR.Shared.DTOs
{
    public class ObjectiveReadDTO
    {
        public long Id { get; set; }
        public DateTime? DateCreated { get; set; }
        public string? Objective { get; set; }
        public int? Status { get; set; }
        public int? Year { get; set; }
        public string? Username { get; set; }
    }
}
