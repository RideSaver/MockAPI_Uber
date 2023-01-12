using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace UberAPI.Models
{ 
    [DataContract]
    public class PaymentMethod : IEquatable<PaymentMethod>
    { 
        [DataMember]
        public string PaymentMethodId { get; set; }

        [DataMember]
        public string Type { get; set; }

        [DataMember]
        public string Description { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentMethod {\n");
            sb.Append("  PaymentMethodId: ").Append(PaymentMethodId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return obj.GetType() == GetType() && Equals((PaymentMethod)obj);
        }
        public bool Equals(PaymentMethod other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    PaymentMethodId == other.PaymentMethodId ||
                    PaymentMethodId != null &&
                    PaymentMethodId.Equals(other.PaymentMethodId)
                ) && 
                (
                    Type == other.Type ||
                    Type != null &&
                    Type.Equals(other.Type)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                );
        }
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (PaymentMethodId != null)
                    hashCode = hashCode * 59 + PaymentMethodId.GetHashCode();
                    if (Type != null)
                    hashCode = hashCode * 59 + Type.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(PaymentMethod left, PaymentMethod right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(PaymentMethod left, PaymentMethod right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
