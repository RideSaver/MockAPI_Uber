using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace UberAPI.Models
{ 
    [DataContract]
    public class TimeEstimate : IEquatable<TimeEstimate>
    { 
        [DataMember]
        public string LocalizedDisplayName { get; set; }

        [DataMember]
        public int? Estimate { get; set; }

        [DataMember]
        public string DisplayName { get; set; }

        [DataMember]
        public string ProductId { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TimeEstimate {\n");
            sb.Append("  LocalizedDisplayName: ").Append(LocalizedDisplayName).Append("\n");
            sb.Append("  Estimate: ").Append(Estimate).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
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
            return obj.GetType() == GetType() && Equals((TimeEstimate)obj);
        }
        public bool Equals(TimeEstimate other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    LocalizedDisplayName == other.LocalizedDisplayName ||
                    LocalizedDisplayName != null &&
                    LocalizedDisplayName.Equals(other.LocalizedDisplayName)
                ) && 
                (
                    Estimate == other.Estimate ||
                    Estimate != null &&
                    Estimate.Equals(other.Estimate)
                ) && 
                (
                    DisplayName == other.DisplayName ||
                    DisplayName != null &&
                    DisplayName.Equals(other.DisplayName)
                ) && 
                (
                    ProductId == other.ProductId ||
                    ProductId != null &&
                    ProductId.Equals(other.ProductId)
                );
        }
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (LocalizedDisplayName != null)
                    hashCode = hashCode * 59 + LocalizedDisplayName.GetHashCode();
                    if (Estimate != null)
                    hashCode = hashCode * 59 + Estimate.GetHashCode();
                    if (DisplayName != null)
                    hashCode = hashCode * 59 + DisplayName.GetHashCode();
                    if (ProductId != null)
                    hashCode = hashCode * 59 + ProductId.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(TimeEstimate left, TimeEstimate right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(TimeEstimate left, TimeEstimate right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
