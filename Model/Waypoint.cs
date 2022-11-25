namespace UberAPI.Model
{
    public class Waypoint
    {
        public Guid RiderId { get; set; } // The hashed rider uuid

        public string? Type { get; set; } // The type of the waypoints. e.g., ‘pickup’, ‘dropoff’.
        public float latitude { get; set; }
        public float longitude { get; set; }
    }
}
