namespace Anton.Models
{
    public class Company
    {
        public int CompanyID { get; set; }
        public string CompanyName { get; set; }
        public string Supervisor { get; set; }

        public ICollection<Artist> Artists { get; set; }
    }
}
