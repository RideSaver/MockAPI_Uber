using System.ComponentModel.DataAnnotations;

namespace UberAPI.Model
{
    public class PriceEstimate
    {
        [Required]
        public Guid ProductId { get; set; } // Unique identified representing a specific product for given lat/long
        [Required]
        public float Distance { get; set; } // Expected activity distance (in miles).
        [Required]
        public string? Estimate { get; set; } // Formatted string of estimate in local currency of the start location. Estimate could be a range, a single number (flat rate) or "Metered" for TAXI
        [Required]
        public string? Currency_Code { get; set; } // Currency Code
        public string? Localized_Display_Name { get; set; } // Localized display name of product.
        public string? Display_Name { get; set; } // Display name of product.
        public double High_Estimate { get; set; } // Upper bound of the estimated price
        public double Low_Estimate { get; set; } // Lower bound of the estimated price
        public int Duration { get; set; } // Expected activity duration (in seconds).
        public double Surge_Multipier { get; set; } // Expected surge multiplier


    }
}
