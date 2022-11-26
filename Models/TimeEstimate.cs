namespace UberAPI.Models
{
    public class TimeEstimate
    {
        public Guid ProductId { get; set; } // UUID for the product given lat/long
        public string? Localized_Display_Name { get; set; } // Localized display name of product.
        public int Estimate { get; set; } // ETA for the product (in seconds). Always show estimate in minutes.
        public string? Display_Name { get; set; } // Display name of product

    }
}
