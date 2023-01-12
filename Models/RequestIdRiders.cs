using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace UberAPI.Models
{ 
    [DataContract]
    public class RequestIdRiders : IEquatable<RequestIdRiders>
    { 
        [DataMember(Name="rider_id")]
        public string? RiderId { get; set; }

        [DataMember(Name="first_name")]
        public string? FirstName { get; set; }

        [DataMember(Name="me")]
        public bool? Me { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RequestIdRiders {\n");
            sb.Append("  RiderId: ").Append(RiderId).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  Me: ").Append(Me).Append("\n");
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
            return obj.GetType() == GetType() && Equals((RequestIdRiders)obj);
        }
        public bool Equals(RequestIdRiders other)
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
                    FirstName == other.FirstName ||
                    FirstName != null &&
                    FirstName.Equals(other.FirstName)
                ) && 
                (
                    Me == other.Me ||
                    Me != null &&
                    Me.Equals(other.Me)
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
                    if (FirstName != null)
                    hashCode = hashCode * 59 + FirstName.GetHashCode();
                    if (Me != null)
                    hashCode = hashCode * 59 + Me.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(RequestIdRiders left, RequestIdRiders right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(RequestIdRiders left, RequestIdRiders right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
