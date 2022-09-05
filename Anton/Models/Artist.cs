namespace Anton.Models
{
    public class Artist
    {
        public int ArtistID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string band  { get; set; }
        public string roles { get; set; }
        public int ReportsToID { get; set; }
        public string street { get; set; }
        public DateTime DOB { get; set; }
        public int CompanyID { get; set; }

        public Company Company { get; set; }
        public ICollection<Song> Songs { get; set; }

    }
}
