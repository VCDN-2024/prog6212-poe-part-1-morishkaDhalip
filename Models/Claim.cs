namespace ContractMonthlyClaimSystem.Models
{
    public class Claim
    {
        public int ClaimId { get; set; }
        public int LecturerId { get; set; }
        public DateTime DateSubmitted { get; set; }
        public double HoursWorked { get; set; }
        public double HourlyRate { get; set; }
        public string Status { get; set; } // Pending, Approved, Rejected
        public virtual Lecturer Lecturer { get; set; }
        public virtual ICollection<Document> Documents { get; set; }
    }
}
