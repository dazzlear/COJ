namespace COJ.Models
{
    public class HomeViewModel
    {
        public List<BandMember> Members { get; set; } = new();
        public List<Album> Discography { get; set; } = new();
    }

    public record BandMember(string Name, string Role, string ImagePath);
    public record Album(string Title, string Type, string Year, string Cover, string Url);
}