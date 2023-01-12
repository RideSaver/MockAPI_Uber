using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace UberAPI.Models
{
    [DataContract(Name = "CreateRequests")]
    public class CreateRequests : IEquatable<CreateRequests>, IValidatableObject
    {
        public CreateRequests(string? fare_id = default, string? product_id = default, float start_latitude = default, float end_latitude = default, float start_longitude = default, float end_longitude = default, string? surgeConfirmationId = default, string? paymentMethodId = default, int seats = default)
        {
            FareId = fare_id;
            ProductId = product_id;
            StartLatitude = start_latitude;
            EndLatitude = end_latitude;
            StartLongitude = start_longitude;
            EndLongitude = end_longitude;
            SurgeConfirmationId = surgeConfirmationId;
            PaymentMethodId = paymentMethodId;
            Seats = seats;
        }

        [DataMember(Name = "fare_id", EmitDefaultValue = false)]
        public string? FareId { get; set; }

        [DataMember(Name = "product_id", EmitDefaultValue = false)]
        public string? ProductId { get; set; }

        [DataMember(Name = "start_latitude", EmitDefaultValue = false)]
        public float? StartLatitude { get; set; }

        [DataMember(Name = "end_latitude", EmitDefaultValue = false)]
        public float? EndLatitude { get; set; }

        [DataMember(Name = "start_longitude", EmitDefaultValue = false)]
        public float? StartLongitude { get; set; }

        [DataMember(Name = "end_longitude", EmitDefaultValue = false)]
        public float? EndLongitude { get; set; }

        [DataMember(Name = "surgeConfirmationId", EmitDefaultValue = false)]
        public string? SurgeConfirmationId { get; set; }

        [DataMember(Name = "paymentMethodId", EmitDefaultValue = false)]
        public string? PaymentMethodId { get; set; }

        [DataMember(Name = "seats", EmitDefaultValue = false)]
        public int? Seats { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateRequests {\n");
            sb.Append("  FareId: ").Append(FareId).Append("\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
            sb.Append("  StartLatitude: ").Append(StartLatitude).Append("\n");
            sb.Append("  EndLatitude: ").Append(EndLatitude).Append("\n");
            sb.Append("  StartLongitude: ").Append(StartLongitude).Append("\n");
            sb.Append("  EndLongitude: ").Append(EndLongitude).Append("\n");
            sb.Append("  SurgeConfirmationId: ").Append(SurgeConfirmationId).Append("\n");
            sb.Append("  PaymentMethodId: ").Append(PaymentMethodId).Append("\n");
            sb.Append("  Seats: ").Append(Seats).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        public override bool Equals(object input)
        {
            return Equals((CreateRequests)input);
        }

        public bool Equals(CreateRequests input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    FareId == input.FareId ||
                    (FareId != null &&
                    FareId.Equals(input.FareId))
                ) &&
                (
                    ProductId == input.ProductId ||
                    (ProductId != null &&
                    ProductId.Equals(input.ProductId))
                ) &&
                (
                    StartLatitude == input.StartLatitude ||
                    StartLatitude.Equals(input.StartLatitude)
                ) &&
                (
                    EndLatitude == input.EndLatitude ||
                    EndLatitude.Equals(input.EndLatitude)
                ) &&
                (
                    StartLongitude == input.StartLongitude ||
                    StartLongitude.Equals(input.StartLongitude)
                ) &&
                (
                    EndLongitude == input.EndLongitude ||
                    EndLongitude.Equals(input.EndLongitude)
                ) &&
                (
                    SurgeConfirmationId == input.SurgeConfirmationId ||
                    (SurgeConfirmationId != null &&
                    SurgeConfirmationId.Equals(input.SurgeConfirmationId))
                ) &&
                (
                    PaymentMethodId == input.PaymentMethodId ||
                    (PaymentMethodId != null &&
                    PaymentMethodId.Equals(input.PaymentMethodId))
                ) &&
                (
                    Seats == input.Seats ||
                    Seats.Equals(input.Seats)
                );
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.FareId != null)
                {
                    hashCode = (hashCode * 59) + this.FareId.GetHashCode();
                }
                if (this.ProductId != null)
                {
                    hashCode = (hashCode * 59) + this.ProductId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.StartLatitude.GetHashCode();
                hashCode = (hashCode * 59) + this.EndLatitude.GetHashCode();
                hashCode = (hashCode * 59) + this.StartLongitude.GetHashCode();
                hashCode = (hashCode * 59) + this.EndLongitude.GetHashCode();
                if (this.SurgeConfirmationId != null)
                {
                    hashCode = (hashCode * 59) + this.SurgeConfirmationId.GetHashCode();
                }
                if (this.PaymentMethodId != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentMethodId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Seats.GetHashCode();
                return hashCode;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
