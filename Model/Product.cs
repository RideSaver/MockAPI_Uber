using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace UberAPI.Model
{
    public class Product
    {
        [Required]
        public Guid ProductId { get; set; } // Unique identified representing a specific product for given lat/long
        [Required]
        public bool Upfront_Fare_Enabled { get; set; } 
        [Required]
        public int Capacity { get; set; } // Capacity of the product, for example, 4 people
        [Required]
        public PriceDetails? Price_Details { get; set; }
        public string? Image { get; set; } // Image URL representing the product
        public bool Cash_Enabled { get; set; } // Specifies whether the product allows cash payments
        public bool Shared { get; set; } // Specifies whether the product allows for the pickup/dropoff of other riders during the trip
        public string? Short_Description { get; set; } // An abbreviated description of the product
        public string? Display_Name { get; set; } // Display name of the product
        public string? Product_Group { get; set; } // The product group this product belongs to (rideshare/uberx/uberxl/uberblack/suv/taxi)
        public string? Description { get; set; } // Description of the product
    }
}
