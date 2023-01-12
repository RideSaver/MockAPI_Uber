using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace UberAPI.Models
{
    [DataContract(Name = "CreateRequests")]
    public class CreateRequests : IEquatable<CreateRequests>, IValidatableObject
    {
        public CreateRequests() { }

        [JsonConstructor]
        public CreateRequests(string fareId, string productId, float startLatitude, float endLatitude, float startLongitude, float endLongitude, string surgeConfirmationId, string paymentMethodId, int seats = 4)
        {
            FareId = fareId;
            ProductId = productId;
            StartLatitude = startLatitude;
            EndLatitude = endLatitude;
            StartLongitude = startLongitude;
            EndLongitude = endLongitude;
            SurgeConfirmationId = surgeConfirmationId;
            PaymentMethodId = paymentMethodId;
            Seats = seats;
        }

        [DataMember(Name = "fareId")]
        public string FareId { get; set; }

        [DataMember(Name = "productId")]
        public string ProductId { get; set; }

        [DataMember(Name = "startLatitude")]
        public float StartLatitude { get; set; }

        [DataMember(Name = "endLatitude")]
        public float EndLatitude { get; set; }

        [DataMember(Name = "startLongitude")]
        public float StartLongitude { get; set; }

        [DataMember(Name = "endLongitude")]
        public float EndLongitude { get; set; }

        [DataMember(Name = "surgeConfirmationId")]
        public string SurgeConfirmationId { get; set; }

        [DataMember(Name = "paymentMethodId")]
        public string PaymentMethodId { get; set; }

        [DataMember(Name = "seats")]
        public int Seats { get; set; }

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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
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
