namespace UberAPI.Model
{
    public class PriceDetails
    {
        public float Cost_Per_Minute { get; set; } // The charge per minute
        public string? Distance_Unit { get; set; } // The unit of distance used to calculate the fare (mile or km)
        public float Minimum { get; set; } // Minimum price of a trip
        public float Cost_Per_Distance { get; set; } // Charge per distance unit
        public float Base { get; set; } // Base Price
        public float Cancellation_Fee { get; set; } // The fee if a rider cancels the trip after grace period
        public string? Currency_Code { get; set; } // Currency Code
    }
}
