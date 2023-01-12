using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace UberAPI.Models
{ 
    [DataContract]
    public class ActivitiesHistory : IEquatable<ActivitiesHistory>
    {

        [DataMember]
        public string Status { get; set; }

        [DataMember]
        public float? Distance { get; set; }

        [DataMember]
        public string ProductId { get; set; }

        [DataMember]
        public int? StartTime { get; set; }

        [DataMember]
        public ActivitiesHistoryStartCity StartCity { get; set; }

        [DataMember]
        public Object EndTime { get; set; }

        [DataMember]
        public string RequestId { get; set; }

        [DataMember]
        public int? RequestTime { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActivitiesHistory {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Distance: ").Append(Distance).Append("\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  StartCity: ").Append(StartCity).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
            sb.Append("  RequestTime: ").Append(RequestTime).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ActivitiesHistory)obj);
        }

        public bool Equals(ActivitiesHistory other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Status == other.Status ||
                    Status != null &&
                    Status.Equals(other.Status)
                ) && 
                (
                    Distance == other.Distance ||
                    Distance != null &&
                    Distance.Equals(other.Distance)
                ) && 
                (
                    ProductId == other.ProductId ||
                    ProductId != null &&
                    ProductId.Equals(other.ProductId)
                ) && 
                (
                    StartTime == other.StartTime ||
                    StartTime != null &&
                    StartTime.Equals(other.StartTime)
                ) && 
                (
                    StartCity == other.StartCity ||
                    StartCity != null &&
                    StartCity.Equals(other.StartCity)
                ) && 
                (
                    EndTime == other.EndTime ||
                    EndTime != null &&
                    EndTime.Equals(other.EndTime)
                ) && 
                (
                    RequestId == other.RequestId ||
                    RequestId != null &&
                    RequestId.Equals(other.RequestId)
                ) && 
                (
                    RequestTime == other.RequestTime ||
                    RequestTime != null &&
                    RequestTime.Equals(other.RequestTime)
                );
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Status != null)
                    hashCode = hashCode * 59 + Status.GetHashCode();
                    if (Distance != null)
                    hashCode = hashCode * 59 + Distance.GetHashCode();
                    if (ProductId != null)
                    hashCode = hashCode * 59 + ProductId.GetHashCode();
                    if (StartTime != null)
                    hashCode = hashCode * 59 + StartTime.GetHashCode();
                    if (StartCity != null)
                    hashCode = hashCode * 59 + StartCity.GetHashCode();
                    if (EndTime != null)
                    hashCode = hashCode * 59 + EndTime.GetHashCode();
                    if (RequestId != null)
                    hashCode = hashCode * 59 + RequestId.GetHashCode();
                    if (RequestTime != null)
                    hashCode = hashCode * 59 + RequestTime.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ActivitiesHistory left, ActivitiesHistory right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ActivitiesHistory left, ActivitiesHistory right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
