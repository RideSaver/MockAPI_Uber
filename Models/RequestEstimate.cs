using System.Runtime.Serialization;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace UberAPI.Models
{
    [DataContract(Name = "RequestEstimate")]
    public class RequestEstimate : IEquatable<RequestEstimate>, IValidatableObject
    {
        public RequestEstimate() { }
        public RequestEstimate(string productId = default!, decimal startLatitutde = default, decimal startLongitude = default, string? startPlaceId = default, decimal endLatitude = default, decimal endLongitude = default, string? endPlaceId = default, int? seatCount = default)
        {
            if (string.IsNullOrEmpty(productId))
            {
                throw new ArgumentException("'ProductID cannot be null or empty.");
            }

            ProductId = productId;
            StartLongitude = startLongitude;
            StartLatitude = startLatitutde;
            StartPlaceId = startPlaceId;
            EndLatitude = endLatitude;
            EndLongitude = endLongitude;
            EndPlaceId= endPlaceId;
            SeatCount= seatCount;
        } 

        [DataMember]
        public string? ProductId { get; set; }

        [DataMember]
        public decimal? StartLatitude { get; set; }

        [DataMember]
        public decimal? StartLongitude { get; set; }

        [DataMember]
        public string? StartPlaceId { get; set; }

        [DataMember]
        public decimal? EndLatitude { get; set; }

        [DataMember]
        public decimal? EndLongitude { get; set; }

        [DataMember]
        public string? EndPlaceId { get; set; }

        [DataMember]
        public int? SeatCount { get; set; }


        public override string ToString()
        {
            StringBuilder sb = new();
            sb.Append("class RequestsEstimateRequest {\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
            sb.Append("  StartLatitude: ").Append(StartLatitude).Append("\n");
            sb.Append("  StartLongitude: ").Append(StartLongitude).Append("\n");
            sb.Append("  StartPlaceId: ").Append(StartPlaceId).Append("\n");
            sb.Append("  EndLatitude: ").Append(EndLatitude).Append("\n");
            sb.Append("  EndLongitude: ").Append(EndLongitude).Append("\n");
            sb.Append("  EndPlaceId: ").Append(EndPlaceId).Append("\n");
            sb.Append("  SeatCount: ").Append(SeatCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        public override bool Equals(object? input)
        {
            return Equals((RequestEstimate)input!);
        }

        public bool Equals(RequestEstimate? input)
        {
            if (input == null)
            {
                return false;
            }
            return
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
                    StartLongitude == input.StartLongitude ||
                    StartLongitude.Equals(input.StartLongitude)
                ) &&
                (
                    StartPlaceId == input.StartPlaceId ||
                    (StartPlaceId != null &&
                    StartPlaceId.Equals(input.StartPlaceId))
                ) &&
                (
                    EndLatitude == input.EndLatitude ||
                    EndLatitude.Equals(input.EndLatitude)
                ) &&
                (
                    EndLongitude == input.EndLongitude ||
                    EndLongitude.Equals(input.EndLongitude)
                ) &&
                (
                    EndPlaceId == input.EndPlaceId ||
                    (EndPlaceId != null &&
                    EndPlaceId.Equals(input.EndPlaceId))
                ) &&
                (
                    SeatCount == input.SeatCount ||
                    SeatCount.Equals(input.SeatCount)
                );
        }
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (ProductId != null)
                {
                    hashCode = (hashCode * 59) + ProductId.GetHashCode();
                }
                hashCode = (hashCode * 59) + StartLatitude.GetHashCode();
                hashCode = (hashCode * 59) + StartLongitude.GetHashCode();
                if (StartPlaceId != null)
                {
                    hashCode = (hashCode * 59) + StartPlaceId.GetHashCode();
                }
                hashCode = (hashCode * 59) + EndLatitude.GetHashCode();
                hashCode = (hashCode * 59) + EndLongitude.GetHashCode();
                if (EndPlaceId != null)
                {
                    hashCode = (hashCode * 59) + EndPlaceId.GetHashCode();
                }
                hashCode = (hashCode * 59) + SeatCount.GetHashCode();
                return hashCode;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
