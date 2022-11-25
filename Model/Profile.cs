namespace UberAPI.Model
{
    public class Profile
    {
        public string? Picture { get; set; } // Image URL of the Uber user.
        public string? First_Name { get; set; } // First name of the Uber user.
        public string? Last_Name { get; set; } // Last name of the Uber user.
        public Guid UUID { get; set; } // Unique identifier of the Uber user.
        public Guid RiderID { get; set; } // Encrypted unique identifier of the Uber rider.
        public string? Email { get; set; } // Email address of the Uber user
        public bool Mobile_Verified { get; set; } // Whether the user has confirmed their mobile number.
        public string? Promo_Code { get; set; } // Promo code of the Uber user.  


    }
}
