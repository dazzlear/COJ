namespace COJ.Models
{
    public class HomeViewModel
    {
        public List<BandMember> Members { get; set; } = new();
        public List<Album> Discography { get; set; } = new();
        public List<Show> UpcomingShows { get; set; } = new();
    }

    public record BandMember(string Name, string Role);
    public record Album(string Title, string Type, string Year, string Cover);
    public record Show(string Date, string Venue, string Location, string Status);
}