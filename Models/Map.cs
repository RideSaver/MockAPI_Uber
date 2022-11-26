namespace UberAPI.Models
{
    public class Map
    {
        public Guid RequestId { get; set; }
        public string? HRef { get; set; } // URL to a map representing the requested trip
    }
}
