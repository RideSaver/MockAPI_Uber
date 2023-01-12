using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace UberAPI.Models
{ 
    [DataContract]
    public class Receipt : IEquatable<Receipt>
    { 
        [DataMember]
        public string RequestId { get; set; }

        [DataMember]
        public string Subtotal { get; set; }

        [DataMember]
        public string TotalCharged { get; set; }

        [DataMember]
        public float? TotalOwed { get; set; }

        [DataMember]
        public string TotalFare { get; set; }

        [DataMember]
        public string CurrencyCode { get; set; }

        [DataMember]
        public string Duration { get; set; }

        [DataMember]
        public string Distance { get; set; }

        [DataMember]
        public string DistanceLabel { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Receipt {\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
            sb.Append("  Subtotal: ").Append(Subtotal).Append("\n");
            sb.Append("  TotalCharged: ").Append(TotalCharged).Append("\n");
            sb.Append("  TotalOwed: ").Append(TotalOwed).Append("\n");
            sb.Append("  TotalFare: ").Append(TotalFare).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  Distance: ").Append(Distance).Append("\n");
            sb.Append("  DistanceLabel: ").Append(DistanceLabel).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Receipt)obj);
        }
        public bool Equals(Receipt other)
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
                    Subtotal == other.Subtotal ||
                    Subtotal != null &&
                    Subtotal.Equals(other.Subtotal)
                ) && 
                (
                    TotalCharged == other.TotalCharged ||
                    TotalCharged != null &&
                    TotalCharged.Equals(other.TotalCharged)
                ) && 
                (
                    TotalOwed == other.TotalOwed ||
                    TotalOwed != null &&
                    TotalOwed.Equals(other.TotalOwed)
                ) && 
                (
                    TotalFare == other.TotalFare ||
                    TotalFare != null &&
                    TotalFare.Equals(other.TotalFare)
                ) && 
                (
                    CurrencyCode == other.CurrencyCode ||
                    CurrencyCode != null &&
                    CurrencyCode.Equals(other.CurrencyCode)
                ) && 
                (
                    Duration == other.Duration ||
                    Duration != null &&
                    Duration.Equals(other.Duration)
                ) && 
                (
                    Distance == other.Distance ||
                    Distance != null &&
                    Distance.Equals(other.Distance)
                ) && 
                (
                    DistanceLabel == other.DistanceLabel ||
                    DistanceLabel != null &&
                    DistanceLabel.Equals(other.DistanceLabel)
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
                    if (Subtotal != null)
                    hashCode = hashCode * 59 + Subtotal.GetHashCode();
                    if (TotalCharged != null)
                    hashCode = hashCode * 59 + TotalCharged.GetHashCode();
                    if (TotalOwed != null)
                    hashCode = hashCode * 59 + TotalOwed.GetHashCode();
                    if (TotalFare != null)
                    hashCode = hashCode * 59 + TotalFare.GetHashCode();
                    if (CurrencyCode != null)
                    hashCode = hashCode * 59 + CurrencyCode.GetHashCode();
                    if (Duration != null)
                    hashCode = hashCode * 59 + Duration.GetHashCode();
                    if (Distance != null)
                    hashCode = hashCode * 59 + Distance.GetHashCode();
                    if (DistanceLabel != null)
                    hashCode = hashCode * 59 + DistanceLabel.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Receipt left, Receipt right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Receipt left, Receipt right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
