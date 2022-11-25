namespace UberAPI.Model
{
    public class Trip
    {
        public string? Alias { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public float ETA { get; set; } // The estimated time until arrival at the destination. 
    }
}
