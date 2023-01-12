using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace UberAPI.Models
{ 
    [DataContract]
    public class Payment : IEquatable<Payment>
    { 
 
        [DataMember]
        public List<PaymentMethod> PaymentMethods { get; set; }

        [DataMember]
        public string LastUsed { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Payment {\n");
            sb.Append("  PaymentMethods: ").Append(PaymentMethods).Append("\n");
            sb.Append("  LastUsed: ").Append(LastUsed).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Payment)obj);
        }
        public bool Equals(Payment other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    PaymentMethods == other.PaymentMethods ||
                    PaymentMethods != null &&
                    PaymentMethods.SequenceEqual(other.PaymentMethods)
                ) && 
                (
                    LastUsed == other.LastUsed ||
                    LastUsed != null &&
                    LastUsed.Equals(other.LastUsed)
                );
        }
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (PaymentMethods != null)
                    hashCode = hashCode * 59 + PaymentMethods.GetHashCode();
                    if (LastUsed != null)
                    hashCode = hashCode * 59 + LastUsed.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Payment left, Payment right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Payment left, Payment right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
