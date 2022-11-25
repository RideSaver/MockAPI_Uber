namespace UberAPI.Model
{
    public class Receipt
    {
        public Guid RequestId { get; set; }
        public string? SubTotal { get; set; }
        public string? Total_Charged { get; set; }
        public float Total_Owed { get; set; }
        public string? Total_Fare { get; set; }
        public string? Currency_Code { get; set; }
        public string? Duration { get; set; }
        public string? Distance_Label { get; set; }
    }
}
