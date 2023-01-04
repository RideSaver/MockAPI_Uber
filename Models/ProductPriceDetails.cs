using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace UberAPI.Models
{ 
    [DataContract]
    public class ProductPriceDetails : IEquatable<ProductPriceDetails>
    { 
        [DataMember(Name="cost_per_minute")]
        public float? CostPerMinute { get; set; }

        [DataMember(Name="distance_unit")]
        public string DistanceUnit { get; set; }

        [DataMember(Name="minimum")]
        public float? Minimum { get; set; }

        [DataMember(Name="cost_per_distance")]
        public float? CostPerDistance { get; set; }

        [DataMember(Name="base")]
        public float? _Base { get; set; }

        [DataMember(Name="canellation_fee")]
        public float? CanellationFee { get; set; }
        [DataMember(Name="currency_code")]
        public string CurrencyCode { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductPriceDetails {\n");
            sb.Append("  CostPerMinute: ").Append(CostPerMinute).Append("\n");
            sb.Append("  DistanceUnit: ").Append(DistanceUnit).Append("\n");
            sb.Append("  Minimum: ").Append(Minimum).Append("\n");
            sb.Append("  CostPerDistance: ").Append(CostPerDistance).Append("\n");
            sb.Append("  _Base: ").Append(_Base).Append("\n");
            sb.Append("  CanellationFee: ").Append(CanellationFee).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ProductPriceDetails)obj);
        }
        public bool Equals(ProductPriceDetails other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    CostPerMinute == other.CostPerMinute ||
                    CostPerMinute != null &&
                    CostPerMinute.Equals(other.CostPerMinute)
                ) && 
                (
                    DistanceUnit == other.DistanceUnit ||
                    DistanceUnit != null &&
                    DistanceUnit.Equals(other.DistanceUnit)
                ) && 
                (
                    Minimum == other.Minimum ||
                    Minimum != null &&
                    Minimum.Equals(other.Minimum)
                ) && 
                (
                    CostPerDistance == other.CostPerDistance ||
                    CostPerDistance != null &&
                    CostPerDistance.Equals(other.CostPerDistance)
                ) && 
                (
                    _Base == other._Base ||
                    _Base != null &&
                    _Base.Equals(other._Base)
                ) && 
                (
                    CanellationFee == other.CanellationFee ||
                    CanellationFee != null &&
                    CanellationFee.Equals(other.CanellationFee)
                ) && 
                (
                    CurrencyCode == other.CurrencyCode ||
                    CurrencyCode != null &&
                    CurrencyCode.Equals(other.CurrencyCode)
                );
        }
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (CostPerMinute != null)
                    hashCode = hashCode * 59 + CostPerMinute.GetHashCode();
                    if (DistanceUnit != null)
                    hashCode = hashCode * 59 + DistanceUnit.GetHashCode();
                    if (Minimum != null)
                    hashCode = hashCode * 59 + Minimum.GetHashCode();
                    if (CostPerDistance != null)
                    hashCode = hashCode * 59 + CostPerDistance.GetHashCode();
                    if (_Base != null)
                    hashCode = hashCode * 59 + _Base.GetHashCode();
                    if (CanellationFee != null)
                    hashCode = hashCode * 59 + CanellationFee.GetHashCode();
                    if (CurrencyCode != null)
                    hashCode = hashCode * 59 + CurrencyCode.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ProductPriceDetails left, ProductPriceDetails right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ProductPriceDetails left, ProductPriceDetails right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
