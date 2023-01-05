using System.Runtime.Serialization;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace UberAPI.Models
{
    [DataContract(Name = "EstimateWithSurge")]
    public class EstimateWithSurge : IEquatable<EstimateWithSurge>, IValidatableObject
    {
        public EstimateWithSurge(EstimateWithSurgeEstimate estimate = default, EstimateWithoutSurgeTrip trip = default, int pickupEstimate = default(int))
        {
            Estimate = estimate;
            Trip = trip;
            PickupEstimate = pickupEstimate;
        }

        [DataMember(Name = "estimate", EmitDefaultValue = false)]
        public EstimateWithSurgeEstimate Estimate { get; set; }

        [DataMember(Name = "trip", EmitDefaultValue = false)]
        public EstimateWithoutSurgeTrip Trip { get; set; }

        [DataMember(Name = "pickup_estimate", EmitDefaultValue = false)]
        public int PickupEstimate { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EstimateWithSurge {\n");
            sb.Append("  Estimate: ").Append(Estimate).Append("\n");
            sb.Append("  Trip: ").Append(Trip).Append("\n");
            sb.Append("  PickupEstimate: ").Append(PickupEstimate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        public override bool Equals(object input)
        {
            return this.Equals(input as EstimateWithSurge);
        }

        public bool Equals(EstimateWithSurge input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Estimate == input.Estimate ||
                    (this.Estimate != null &&
                    this.Estimate.Equals(input.Estimate))
                ) && 
                (
                    this.Trip == input.Trip ||
                    (this.Trip != null &&
                    this.Trip.Equals(input.Trip))
                ) && 
                (
                    this.PickupEstimate == input.PickupEstimate ||
                    this.PickupEstimate.Equals(input.PickupEstimate)
                );
        }
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Estimate != null)
                {
                    hashCode = (hashCode * 59) + this.Estimate.GetHashCode();
                }
                if (this.Trip != null)
                {
                    hashCode = (hashCode * 59) + this.Trip.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PickupEstimate.GetHashCode();
                return hashCode;
            }
        }
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
