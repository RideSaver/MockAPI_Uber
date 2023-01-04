using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace UberAPI.Models
{ 
    [DataContract]
    public class Map : IEquatable<Map>
    { 
        [DataMember(Name="request_id")]
        public string RequestId { get; set; }

        [DataMember(Name="href")]
        public string Href { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Map {\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Map)obj);
        }
        public bool Equals(Map other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    RequestId == other.RequestId ||
                    RequestId != null &&
                    RequestId.Equals(other.RequestId)
                ) && 
                (
                    Href == other.Href ||
                    Href != null &&
                    Href.Equals(other.Href)
                );
        }
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (RequestId != null)
                    hashCode = hashCode * 59 + RequestId.GetHashCode();
                    if (Href != null)
                    hashCode = hashCode * 59 + Href.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Map left, Map right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Map left, Map right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
