using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace UberAPI.Models
{
    [DataContract(Name = "request_id_location")]
    public class RequestIdLocation : IEquatable<RequestIdLocation>
    {
        public RequestIdLocation(float latitude, float longitude, int bearing)
        {
            Latitude = latitude;
            Longitude = longitude;
            Bearing = bearing;
        }

        [DataMember]
        public float? Latitude { get; set; }

        [DataMember]
        public float? Longitude { get; set; }

        [DataMember]
        public int? Bearing { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RequestIdLocation {\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("  Bearing: ").Append(Bearing).Append("\n");
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
            return obj.GetType() == GetType() && Equals((RequestIdLocation)obj);
        }
        public bool Equals(RequestIdLocation other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Latitude == other.Latitude ||
                    Latitude != null &&
                    Latitude.Equals(other.Latitude)
                ) && 
                (
                    Longitude == other.Longitude ||
                    Longitude != null &&
                    Longitude.Equals(other.Longitude)
                ) && 
                (
                    Bearing == other.Bearing ||
                    Bearing != null &&
                    Bearing.Equals(other.Bearing)
                );
        }
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Latitude != null)
                    hashCode = hashCode * 59 + Latitude.GetHashCode();
                    if (Longitude != null)
                    hashCode = hashCode * 59 + Longitude.GetHashCode();
                    if (Bearing != null)
                    hashCode = hashCode * 59 + Bearing.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(RequestIdLocation left, RequestIdLocation right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(RequestIdLocation left, RequestIdLocation right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
