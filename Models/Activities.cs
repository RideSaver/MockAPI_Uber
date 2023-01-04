using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace UberAPI.Models
{ 
    [DataContract]
    public class Activities : IEquatable<Activities>
    { 
        [DataMember(Name="count")]
        public int? Count { get; set; }

        [DataMember(Name="history")]
        public ActivitiesHistory History { get; set; }

        [DataMember(Name="limit")]
        public int? Limit { get; set; }

        [DataMember(Name="offset")]
        public int? Offset { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Activities {\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  History: ").Append(History).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  Offset: ").Append(Offset).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Activities)obj);
        }

        public bool Equals(Activities other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Count == other.Count ||
                    Count != null &&
                    Count.Equals(other.Count)
                ) && 
                (
                    History == other.History ||
                    History != null &&
                    History.Equals(other.History)
                ) && 
                (
                    Limit == other.Limit ||
                    Limit != null &&
                    Limit.Equals(other.Limit)
                ) && 
                (
                    Offset == other.Offset ||
                    Offset != null &&
                    Offset.Equals(other.Offset)
                );
        }
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Count != null)
                    hashCode = hashCode * 59 + Count.GetHashCode();
                    if (History != null)
                    hashCode = hashCode * 59 + History.GetHashCode();
                    if (Limit != null)
                    hashCode = hashCode * 59 + Limit.GetHashCode();
                    if (Offset != null)
                    hashCode = hashCode * 59 + Offset.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Activities left, Activities right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Activities left, Activities right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
