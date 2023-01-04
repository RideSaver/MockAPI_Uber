using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace UberAPI.Models
{ 
    [DataContract]
    public class PriceEstimate : IEquatable<PriceEstimate>
    { 
        [DataMember(Name="localized_display_name")]
        public string LocalizedDisplayName { get; set; }

        [DataMember(Name="distance")]
        public float? Distance { get; set; }

        [DataMember(Name="display_name")]
        public string DisplayName { get; set; }

        [DataMember(Name="product_id")]
        public string ProductId { get; set; }

        [DataMember(Name="high_estimate")]
        public decimal? HighEstimate { get; set; }

        [DataMember(Name="low_estimate")]
        public decimal? LowEstimate { get; set; }

        [DataMember(Name="duration")]
        public int? Duration { get; set; }

        [DataMember(Name="estimate")]
        public string Estimate { get; set; }

        [DataMember(Name="surge_multiplier")]
        public decimal? SurgeMultiplier { get; set; }

        [DataMember(Name="currency_code")]
        public string CurrencyCode { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PriceEstimate {\n");
            sb.Append("  LocalizedDisplayName: ").Append(LocalizedDisplayName).Append("\n");
            sb.Append("  Distance: ").Append(Distance).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
            sb.Append("  HighEstimate: ").Append(HighEstimate).Append("\n");
            sb.Append("  LowEstimate: ").Append(LowEstimate).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  Estimate: ").Append(Estimate).Append("\n");
            sb.Append("  SurgeMultiplier: ").Append(SurgeMultiplier).Append("\n");
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
            return obj.GetType() == GetType() && Equals((PriceEstimate)obj);
        }
        public bool Equals(PriceEstimate other)
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
                    Distance == other.Distance ||
                    Distance != null &&
                    Distance.Equals(other.Distance)
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
                ) && 
                (
                    HighEstimate == other.HighEstimate ||
                    HighEstimate != null &&
                    HighEstimate.Equals(other.HighEstimate)
                ) && 
                (
                    LowEstimate == other.LowEstimate ||
                    LowEstimate != null &&
                    LowEstimate.Equals(other.LowEstimate)
                ) && 
                (
                    Duration == other.Duration ||
                    Duration != null &&
                    Duration.Equals(other.Duration)
                ) && 
                (
                    Estimate == other.Estimate ||
                    Estimate != null &&
                    Estimate.Equals(other.Estimate)
                ) && 
                (
                    SurgeMultiplier == other.SurgeMultiplier ||
                    SurgeMultiplier != null &&
                    SurgeMultiplier.Equals(other.SurgeMultiplier)
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
                    if (LocalizedDisplayName != null)
                    hashCode = hashCode * 59 + LocalizedDisplayName.GetHashCode();
                    if (Distance != null)
                    hashCode = hashCode * 59 + Distance.GetHashCode();
                    if (DisplayName != null)
                    hashCode = hashCode * 59 + DisplayName.GetHashCode();
                    if (ProductId != null)
                    hashCode = hashCode * 59 + ProductId.GetHashCode();
                    if (HighEstimate != null)
                    hashCode = hashCode * 59 + HighEstimate.GetHashCode();
                    if (LowEstimate != null)
                    hashCode = hashCode * 59 + LowEstimate.GetHashCode();
                    if (Duration != null)
                    hashCode = hashCode * 59 + Duration.GetHashCode();
                    if (Estimate != null)
                    hashCode = hashCode * 59 + Estimate.GetHashCode();
                    if (SurgeMultiplier != null)
                    hashCode = hashCode * 59 + SurgeMultiplier.GetHashCode();
                    if (CurrencyCode != null)
                    hashCode = hashCode * 59 + CurrencyCode.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(PriceEstimate left, PriceEstimate right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(PriceEstimate left, PriceEstimate right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
