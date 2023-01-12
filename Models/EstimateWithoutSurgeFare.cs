using System.Runtime.Serialization;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace UberAPI.Models
{
    [DataContract(Name = "EstimateWithoutSurge_fare")]
    public class EstimateWithoutSurgeFare : IEquatable<EstimateWithoutSurgeFare>, IValidatableObject
    {
        public EstimateWithoutSurgeFare(decimal value = default(decimal), string fareId = default(string), int expiresAt = default(int), string display = default(string), string currencyCode = default(string), List<EstimateWithoutSurgeFareBreakdownInner> breakdown = default(List<EstimateWithoutSurgeFareBreakdownInner>))
        {
            this.Value = value;
            this.FareId = fareId;
            this.ExpiresAt = expiresAt;
            this.Display = display;
            this.CurrencyCode = currencyCode;
            this.Breakdown = breakdown;
        }

        [DataMember]
        public decimal Value { get; set; }

        [DataMember]
        public string FareId { get; set; }
            
        [DataMember]
        public int ExpiresAt { get; set; }

        [DataMember]
        public string Display { get; set; }

        [DataMember]
        public string CurrencyCode { get; set; }

        [DataMember]
        public List<EstimateWithoutSurgeFareBreakdownInner> Breakdown { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EstimateWithoutSurgeFare {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  FareId: ").Append(FareId).Append("\n");
            sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");
            sb.Append("  Display: ").Append(Display).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  Breakdown: ").Append(Breakdown).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as EstimateWithoutSurgeFare);
        }

        public bool Equals(EstimateWithoutSurgeFare input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Value == input.Value ||
                    this.Value.Equals(input.Value)
                ) && 
                (
                    this.FareId == input.FareId ||
                    (this.FareId != null &&
                    this.FareId.Equals(input.FareId))
                ) && 
                (
                    this.ExpiresAt == input.ExpiresAt ||
                    this.ExpiresAt.Equals(input.ExpiresAt)
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
                ) && 
                (
                    this.Breakdown == input.Breakdown ||
                    this.Breakdown != null &&
                    input.Breakdown != null &&
                    this.Breakdown.SequenceEqual(input.Breakdown)
                );
        }
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = (hashCode * 59) + this.Value.GetHashCode();
                if (this.FareId != null)
                {
                    hashCode = (hashCode * 59) + this.FareId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ExpiresAt.GetHashCode();
                if (this.Display != null)
                {
                    hashCode = (hashCode * 59) + this.Display.GetHashCode();
                }
                if (this.CurrencyCode != null)
                {
                    hashCode = (hashCode * 59) + this.CurrencyCode.GetHashCode();
                }
                if (this.Breakdown != null)
                {
                    hashCode = (hashCode * 59) + this.Breakdown.GetHashCode();
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
