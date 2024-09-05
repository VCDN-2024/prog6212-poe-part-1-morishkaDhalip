namespace ContractMonthlyClaimSystem.Models
{
    public class Document
    {
        public int DocumentId { get; set; }
        public int ClaimId { get; set; }
        public string FilePath { get; set; }
        public virtual Claim Claim { get; set; }
    }
}
