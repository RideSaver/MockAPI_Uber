using Microsoft.AspNetCore.Components.Routing;

namespace UberAPI.Models
{
    public class RequestID
    {
        public Guid ProductId { get; set; }
        public Guid RequestId { get; set; }
        public string? Status { get; set; }
        public float Surge_Multiplier { get; set; }
        public bool Shared { get; set; }
        public Driver? Driver { get; set; }
        public Vehicle? Vehicle { get; set; }
        public Location? Location { get; set; }
        public Location? Pickup { get; set; }
        public Location? Destination { get; set; }
        public Waypoint? Waypoints { get; set; }
        public Rider? Riders { get; set; }
      

    }
}
