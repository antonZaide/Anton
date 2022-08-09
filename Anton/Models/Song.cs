namespace Anton.Models
{
    public class Song
    {
        public int SongID { get; set; }
        public string Title { get; set; }
        public DateTime DateReleased { get; set; }

        public ICollection<Artist> Artists { get; set; }
    }
}
