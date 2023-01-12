using System.Runtime.Serialization;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace UberAPI.Models
{
    [DataContract(Name = "EstimateWithSurge_estimate")]
    public class EstimateWithSurgeEstimate : IEquatable<EstimateWithSurgeEstimate>, IValidatableObject
    {
        public EstimateWithSurgeEstimate(string surgeConfirmationHref = default(string), int highEstimate = default(int), string surgeConfirmationId = default(string), int minimum = default(int), int lowEstimate = default(int), List<EstimateWithSurgeEstimateFareBreakdownInner> fareBreakdown = default(List<EstimateWithSurgeEstimateFareBreakdownInner>), decimal surgeMultiplier = default(decimal), string display = default(string), string currencyCode = default(string))
        {
            SurgeConfirmationHref = surgeConfirmationHref;
            HighEstimate = highEstimate;
            SurgeConfirmationId = surgeConfirmationId;
            Minimum = minimum;
            LowEstimate = lowEstimate;
            FareBreakdown = fareBreakdown;
            SurgeMultiplier = surgeMultiplier;
            Display = display;
            CurrencyCode = currencyCode;
        }

        [DataMember]
        public string SurgeConfirmationHref { get; set; }

        [DataMember]
        public int HighEstimate { get; set; }

        [DataMember]
        public string SurgeConfirmationId { get; set; }

        [DataMember]
        public int Minimum { get; set; }

        [DataMember]
        public int LowEstimate { get; set; }

        [DataMember]
        public List<EstimateWithSurgeEstimateFareBreakdownInner> FareBreakdown { get; set; }

        [DataMember]
        public decimal SurgeMultiplier { get; set; }

        [DataMember]
        public string Display { get; set; }

        [DataMember]
        public string CurrencyCode { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EstimateWithSurgeEstimate {\n");
            sb.Append("  SurgeConfirmationHref: ").Append(SurgeConfirmationHref).Append("\n");
            sb.Append("  HighEstimate: ").Append(HighEstimate).Append("\n");
            sb.Append("  SurgeConfirmationId: ").Append(SurgeConfirmationId).Append("\n");
            sb.Append("  Minimum: ").Append(Minimum).Append("\n");
            sb.Append("  LowEstimate: ").Append(LowEstimate).Append("\n");
            sb.Append("  FareBreakdown: ").Append(FareBreakdown).Append("\n");
            sb.Append("  SurgeMultiplier: ").Append(SurgeMultiplier).Append("\n");
            sb.Append("  Display: ").Append(Display).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        public override bool Equals(object input)
        {
            return this.Equals(input as EstimateWithSurgeEstimate);
        }
        public bool Equals(EstimateWithSurgeEstimate input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SurgeConfirmationHref == input.SurgeConfirmationHref ||
                    (this.SurgeConfirmationHref != null &&
                    this.SurgeConfirmationHref.Equals(input.SurgeConfirmationHref))
                ) && 
                (
                    this.HighEstimate == input.HighEstimate ||
                    this.HighEstimate.Equals(input.HighEstimate)
                ) && 
                (
                    this.SurgeConfirmationId == input.SurgeConfirmationId ||
                    (this.SurgeConfirmationId != null &&
                    this.SurgeConfirmationId.Equals(input.SurgeConfirmationId))
                ) && 
                (
                    this.Minimum == input.Minimum ||
                    this.Minimum.Equals(input.Minimum)
                ) && 
                (
                    this.LowEstimate == input.LowEstimate ||
                    this.LowEstimate.Equals(input.LowEstimate)
                ) && 
                (
                    this.FareBreakdown == input.FareBreakdown ||
                    this.FareBreakdown != null &&
                    input.FareBreakdown != null &&
                    this.FareBreakdown.SequenceEqual(input.FareBreakdown)
                ) && 
                (
                    this.SurgeMultiplier == input.SurgeMultiplier ||
                    this.SurgeMultiplier.Equals(input.SurgeMultiplier)
                ) && 
                (
                    this.Display == input.Display ||
                    (this.Display != null &&
                    this.Display.Equals(input.Display))
                ) && 
                (
                    this.CurrencyCode == input.CurrencyCode ||
                    (this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(input.CurrencyCode))
                );
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.SurgeConfirmationHref != null)
                {
                    hashCode = (hashCode * 59) + this.SurgeConfirmationHref.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.HighEstimate.GetHashCode();
                if (this.SurgeConfirmationId != null)
                {
                    hashCode = (hashCode * 59) + this.SurgeConfirmationId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Minimum.GetHashCode();
                hashCode = (hashCode * 59) + this.LowEstimate.GetHashCode();
                if (this.FareBreakdown != null)
                {
                    hashCode = (hashCode * 59) + this.FareBreakdown.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SurgeMultiplier.GetHashCode();
                if (this.Display != null)
                {
                    hashCode = (hashCode * 59) + this.Display.GetHashCode();
                }
                if (this.CurrencyCode != null)
                {
                    hashCode = (hashCode * 59) + this.CurrencyCode.GetHashCode();
                }
                return hashCode;
            }
        }

        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
