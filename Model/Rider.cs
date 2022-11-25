namespace UberAPI.Model
{
    public class Rider
    {
       public Guid RiderId { get; set; }
        public string? First_Name { get; set; }
        public bool Me { get; set; } // If true, this rider is the current authenticated user.
    }
}
