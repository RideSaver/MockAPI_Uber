using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace UberAPI.Models
{ 
    public class Requests : IEquatable<Requests>
    { 
        [Required]
        [DataMember(Name="fare_id")]
        public string FareId { get; set; }

        [DataMember(Name="product_id")]
        public string ProductId { get; set; }

        [Required]
        [DataMember(Name="start_latitude")]
        public float? StartLatitude { get; set; }

        [Required]
        [DataMember(Name="end_latitude")]
        public float? EndLatitude { get; set; }

        [Required]
        [DataMember(Name="start_longitude")]
        public float? StartLongitude { get; set; }

        [Required]
        [DataMember(Name="end_longitude")]
        public float? EndLongitude { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Requests {\n");
            sb.Append("  FareId: ").Append(FareId).Append("\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
            sb.Append("  StartLatitude: ").Append(StartLatitude).Append("\n");
            sb.Append("  EndLatitude: ").Append(EndLatitude).Append("\n");
            sb.Append("  StartLongitude: ").Append(StartLongitude).Append("\n");
            sb.Append("  EndLongitude: ").Append(EndLongitude).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Requests)obj);
        }
        public bool Equals(Requests other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    FareId == other.FareId ||
                    FareId != null &&
                    FareId.Equals(other.FareId)
                ) && 
                (
                    ProductId == other.ProductId ||
                    ProductId != null &&
                    ProductId.Equals(other.ProductId)
                ) && 
                (
                    StartLatitude == other.StartLatitude ||
                    StartLatitude != null &&
                    StartLatitude.Equals(other.StartLatitude)
                ) && 
                (
                    EndLatitude == other.EndLatitude ||
                    EndLatitude != null &&
                    EndLatitude.Equals(other.EndLatitude)
                ) && 
                (
                    StartLongitude == other.StartLongitude ||
                    StartLongitude != null &&
                    StartLongitude.Equals(other.StartLongitude)
                ) && 
                (
                    EndLongitude == other.EndLongitude ||
                    EndLongitude != null &&
                    EndLongitude.Equals(other.EndLongitude)
                );
        }
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (FareId != null)
                    hashCode = hashCode * 59 + FareId.GetHashCode();
                    if (ProductId != null)
                    hashCode = hashCode * 59 + ProductId.GetHashCode();
                    if (StartLatitude != null)
                    hashCode = hashCode * 59 + StartLatitude.GetHashCode();
                    if (EndLatitude != null)
                    hashCode = hashCode * 59 + EndLatitude.GetHashCode();
                    if (StartLongitude != null)
                    hashCode = hashCode * 59 + StartLongitude.GetHashCode();
                    if (EndLongitude != null)
                    hashCode = hashCode * 59 + EndLongitude.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Requests left, Requests right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Requests left, Requests right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
