using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace UberAPI.Models
{
    [DataContract(Name = "EstimateWithoutSurge_trip")]
    public class EstimateWithoutSurgeTrip : IEquatable<EstimateWithoutSurgeTrip>, IValidatableObject
    {
        [JsonConstructor]
        protected EstimateWithoutSurgeTrip() { }
        public EstimateWithoutSurgeTrip(string distanceUnit = default, int durationEstimate = default(int), decimal distanceEstimate = default(decimal))
        {
            DistanceUnit = distanceUnit;
            DurationEstimate = durationEstimate;
            DistanceEstimate = distanceEstimate;
        }
        [DataMember]
        public string DistanceUnit { get; set; }

        [DataMember]
        public int DurationEstimate { get; set; }

        [DataMember]
        public decimal DistanceEstimate { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EstimateWithoutSurgeTrip {\n");
            sb.Append("  DistanceUnit: ").Append(DistanceUnit).Append("\n");
            sb.Append("  DurationEstimate: ").Append(DurationEstimate).Append("\n");
            sb.Append("  DistanceEstimate: ").Append(DistanceEstimate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as EstimateWithoutSurgeTrip);
        }
        public bool Equals(EstimateWithoutSurgeTrip input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DistanceUnit == input.DistanceUnit ||
                    (this.DistanceUnit != null &&
                    this.DistanceUnit.Equals(input.DistanceUnit))
                ) && 
                (
                    this.DurationEstimate == input.DurationEstimate ||
                    this.DurationEstimate.Equals(input.DurationEstimate)
                ) && 
                (
                    this.DistanceEstimate == input.DistanceEstimate ||
                    this.DistanceEstimate.Equals(input.DistanceEstimate)
                );
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.DistanceUnit != null)
                {
                    hashCode = (hashCode * 59) + this.DistanceUnit.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DurationEstimate.GetHashCode();
                hashCode = (hashCode * 59) + this.DistanceEstimate.GetHashCode();
                return hashCode;
            }
        }

        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
