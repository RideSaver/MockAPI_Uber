using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace UberAPI.Models
{
    [DataContract(Name = "request_id_waypoints")]
    public class RequestIdWaypoints : IEquatable<RequestIdWaypoints>
    {
        public RequestIdWaypoints(string riderId = default(string), float latitude = default(float), string type = default(string), float longitude = default(float))
        {
            this.RiderId = riderId;
            this.Latitude = latitude;
            this.Type = type;
            this.Longitude = longitude;
        }

        [DataMember(Name="rider_id")]
        public string? RiderId { get; set; }

        [DataMember(Name="latitude")]
        public float? Latitude { get; set; }

        [DataMember(Name="type")]
        public string? Type { get; set; }

        [DataMember(Name="longitude")]
        public float? Longitude { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RequestIdWaypoints {\n");
            sb.Append("  RiderId: ").Append(RiderId).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
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
            return obj.GetType() == GetType() && Equals((RequestIdWaypoints)obj);
        }
        public bool Equals(RequestIdWaypoints other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    RiderId == other.RiderId ||
                    RiderId != null &&
                    RiderId.Equals(other.RiderId)
                ) && 
                (
                    Latitude == other.Latitude ||
                    Latitude != null &&
                    Latitude.Equals(other.Latitude)
                ) && 
                (
                    Type == other.Type ||
                    Type != null &&
                    Type.Equals(other.Type)
                ) && 
                (
                    Longitude == other.Longitude ||
                    Longitude != null &&
                    Longitude.Equals(other.Longitude)
                );
        }
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (RiderId != null)
                    hashCode = hashCode * 59 + RiderId.GetHashCode();
                    if (Latitude != null)
                    hashCode = hashCode * 59 + Latitude.GetHashCode();
                    if (Type != null)
                    hashCode = hashCode * 59 + Type.GetHashCode();
                    if (Longitude != null)
                    hashCode = hashCode * 59 + Longitude.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(RequestIdWaypoints left, RequestIdWaypoints right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(RequestIdWaypoints left, RequestIdWaypoints right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
