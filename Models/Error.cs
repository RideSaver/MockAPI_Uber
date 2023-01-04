using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace UberAPI.Models
{ 
    [DataContract]
    public class Error : IEquatable<Error>
    { 
        [DataMember(Name="fields")]
        public string Fields { get; set; }

        [DataMember(Name="message")]
        public string Message { get; set; }

        [DataMember(Name="code")]
        public string Code { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Error {\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Error)obj);
        }
        public bool Equals(Error other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Fields == other.Fields ||
                    Fields != null &&
                    Fields.Equals(other.Fields)
                ) && 
                (
                    Message == other.Message ||
                    Message != null &&
                    Message.Equals(other.Message)
                ) && 
                (
                    Code == other.Code ||
                    Code != null &&
                    Code.Equals(other.Code)
                );
        }
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Fields != null)
                    hashCode = hashCode * 59 + Fields.GetHashCode();
                    if (Message != null)
                    hashCode = hashCode * 59 + Message.GetHashCode();
                    if (Code != null)
                    hashCode = hashCode * 59 + Code.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Error left, Error right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Error left, Error right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
