namespace UberAPI.Models
{
    public class Activities
    {
        public int Count { get; set; } // Total number of items available.
        public ActivityHistory? History { get; set; }
        public int Limit { get; set; } // Number of items to retrieve(50 max).
        public double Offset { get; set; } // Position in pagination.

    }
}
