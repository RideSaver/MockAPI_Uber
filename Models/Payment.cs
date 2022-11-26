namespace UberAPI.Models
{
    public class Payment
    {
        public List<PaymentMethod>? Payment_Methods { get; set; } // An array of this user’s payment methods
        public string? Last_Used { get; set; } // The unique identifier of the last used payment method.
    }
}
