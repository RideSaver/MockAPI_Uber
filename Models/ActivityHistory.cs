namespace UberAPI.Models
{
    public class ActivityHistory
    {
        public string? Status { get; set; } // Status of the activity. Only returns completed for now.
        public float Distance { get; set; } // Length of activity in miles.
        public Guid ProductId { get; set; } // Unique identifier representing a specific product for given long/lat
        public DateTime Start_Time { get; set; } // Unix timestamp of activity start time.
        public StartCity? Start_City { get; set; }
        public DateTime? End_Time { get; set; } // Unix timestamp of activity end time.

        public Guid RequestId { get; set; } // Unique activity identifier.
        public DateTime? RequestTime { get; set; }
    }
}
