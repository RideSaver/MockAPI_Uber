namespace UberAPI.Models
{
    public class PaymentMethod
    {
        public Guid PaymentMethodId { get; set; } // Unique identifier of the payment method.
        public string? Type { get; set; } // The type of the payment method (See below for details).
        public string? Description { get; set; } // The account identification or description associated with the payment method.
    }
}
