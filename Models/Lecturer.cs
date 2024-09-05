namespace ContractMonthlyClaimSystem.Models
{
    public class Lecturer
    {
        public int LecturerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Claim> Claims { get; set; }
    }
}
