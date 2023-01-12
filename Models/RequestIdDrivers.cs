using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace UberAPI.Models
{
    [DataContract(Name = "request_id_drivers")]
    public class RequestIdDrivers : IEquatable<RequestIdDrivers>
    {
        [JsonConstructor]
        public RequestIdDrivers() { }
        public RequestIdDrivers(string phoneNumber, string smsNumber, float rating, string pictureUrl, string name)
        {
            PhoneNumber = phoneNumber;
            SmsNumber = smsNumber;
            Rating = rating;
            PictureUrl = pictureUrl;
            Name = name;
        }

        [DataMember]
        public string? PhoneNumber { get; set; }

        [DataMember]
        public string? SmsNumber { get; set; }

        [DataMember]
        public float? Rating { get; set; }

        [DataMember]
        public string? PictureUrl { get; set; }

        [DataMember]
        public string? Name { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RequestIdDrivers {\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  SmsNumber: ").Append(SmsNumber).Append("\n");
            sb.Append("  Rating: ").Append(Rating).Append("\n");
            sb.Append("  PictureUrl: ").Append(PictureUrl).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((RequestIdDrivers)obj);
        }

        public bool Equals(RequestIdDrivers other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    PhoneNumber == other.PhoneNumber ||
                    PhoneNumber != null &&
                    PhoneNumber.Equals(other.PhoneNumber)
                ) && 
                (
                    SmsNumber == other.SmsNumber ||
                    SmsNumber != null &&
                    SmsNumber.Equals(other.SmsNumber)
                ) && 
                (
                    Rating == other.Rating ||
                    Rating != null &&
                    Rating.Equals(other.Rating)
                ) && 
                (
                    PictureUrl == other.PictureUrl ||
                    PictureUrl != null &&
                    PictureUrl.Equals(other.PictureUrl)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                );
        }
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (PhoneNumber != null)
                    hashCode = hashCode * 59 + PhoneNumber.GetHashCode();
                    if (SmsNumber != null)
                    hashCode = hashCode * 59 + SmsNumber.GetHashCode();
                    if (Rating != null)
                    hashCode = hashCode * 59 + Rating.GetHashCode();
                    if (PictureUrl != null)
                    hashCode = hashCode * 59 + PictureUrl.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(RequestIdDrivers left, RequestIdDrivers right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(RequestIdDrivers left, RequestIdDrivers right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
