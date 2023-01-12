using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace UberAPI.Models
{
    [DataContract(Name = "trip")]
    public class Trip : IEquatable<Trip>
    {
        public Trip(string alias, float latitude, float longitude, string name, string address, float eta)
        {
            Alias = alias;
            Latitude = latitude;
            Longitude = longitude;
            Name = name;
            Address = address;
            Eta = eta;
        }

        [DataMember]
        public string? Alias { get; set; }

        [DataMember]
        public float? Latitude { get; set; }

        [DataMember]
        public float? Longitude { get; set; }

        [DataMember]
        public string? Name { get; set; }

        [DataMember]
        public string? Address { get; set; }

        [DataMember]
        public float? Eta { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Trip {\n");
            sb.Append("  Alias: ").Append(Alias).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Eta: ").Append(Eta).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Trip)obj);
        }

        public bool Equals(Trip other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Alias == other.Alias ||
                    Alias != null &&
                    Alias.Equals(other.Alias)
                ) && 
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
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    Address == other.Address ||
                    Address != null &&
                    Address.Equals(other.Address)
                ) && 
                (
                    Eta == other.Eta ||
                    Eta != null &&
                    Eta.Equals(other.Eta)
                );
        }
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Alias != null)
                    hashCode = hashCode * 59 + Alias.GetHashCode();
                    if (Latitude != null)
                    hashCode = hashCode * 59 + Latitude.GetHashCode();
                    if (Longitude != null)
                    hashCode = hashCode * 59 + Longitude.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (Address != null)
                    hashCode = hashCode * 59 + Address.GetHashCode();
                    if (Eta != null)
                    hashCode = hashCode * 59 + Eta.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Trip left, Trip right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Trip left, Trip right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
