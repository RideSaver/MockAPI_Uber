using System.Runtime.Serialization;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace UberAPI.Models
{
    [DataContract(Name = "EstimateWithSurge_estimate_fare_breakdown_inner")]
    public class EstimateWithSurgeEstimateFareBreakdownInner : IEquatable<EstimateWithSurgeEstimateFareBreakdownInner>, IValidatableObject
    {
        public EstimateWithSurgeEstimateFareBreakdownInner(decimal lowAmount = default(decimal), decimal highAmount = default(decimal), string displayAmount = default(string), string displayName = default(string))
        {
            LowAmount = lowAmount;
            HighAmount = highAmount;
            DisplayAmount = displayAmount;
            DisplayName = displayName;
        }

        [DataMember]
        public decimal LowAmount { get; set; }

        [DataMember]
        public decimal HighAmount { get; set; }

        [DataMember]
        public string DisplayAmount { get; set; }

        [DataMember]
        public string DisplayName { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EstimateWithSurgeEstimateFareBreakdownInner {\n");
            sb.Append("  LowAmount: ").Append(LowAmount).Append("\n");
            sb.Append("  HighAmount: ").Append(HighAmount).Append("\n");
            sb.Append("  DisplayAmount: ").Append(DisplayAmount).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        public override bool Equals(object input)
        {
            return this.Equals(input as EstimateWithSurgeEstimateFareBreakdownInner);
        }

        public bool Equals(EstimateWithSurgeEstimateFareBreakdownInner input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.LowAmount == input.LowAmount ||
                    this.LowAmount.Equals(input.LowAmount)
                ) && 
                (
                    this.HighAmount == input.HighAmount ||
                    this.HighAmount.Equals(input.HighAmount)
                ) && 
                (
                    this.DisplayAmount == input.DisplayAmount ||
                    (this.DisplayAmount != null &&
                    this.DisplayAmount.Equals(input.DisplayAmount))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                );
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = (hashCode * 59) + this.LowAmount.GetHashCode();
                hashCode = (hashCode * 59) + this.HighAmount.GetHashCode();
                if (this.DisplayAmount != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayAmount.GetHashCode();
                }
                if (this.DisplayName != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayName.GetHashCode();
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
