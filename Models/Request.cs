using System.ComponentModel.DataAnnotations;

namespace UberAPI.Models
{
    public class Request
    {
        [Required]
        public Guid FareId { get; set; } // The key for the upfront fare of a ride.
        [Required]
        public Guid ProductId { get; set; } // The unique ID of the product being requested.
        [Required]
        public float Start_Latitude { get; set; } // The beginning or “pickup” latitude. Either this or start_place_id must be specified.
        [Required]
        public float End_Latitude { get; set; } // The final or destination latitude. Either this or end_place_id may be specified.
        [Required]
        public float Start_Longitude { get; set; } // The beginning or “pickup” longitude. Either this or start_place_id must be specified.
        [Required]
        public float End_Longitude { get; set; } // The final or destination longitude. Either this or end_place_id may be specified.

    }
}
