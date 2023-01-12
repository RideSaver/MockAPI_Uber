using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace UberAPI.Models
{ 
    [DataContract]
    public class ActivitiesHistoryStartCity : IEquatable<ActivitiesHistoryStartCity>
    { 
        [DataMember]
        public float? Latitude { get; set; }

        [DataMember]
        public string DisplayName { get; set; }

        [DataMember]
        public float? Longitude { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActivitiesHistoryStartCity {\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ActivitiesHistoryStartCity)obj);
        }
        public bool Equals(ActivitiesHistoryStartCity other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Latitude == other.Latitude ||
                    Latitude != null &&
                    Latitude.Equals(other.Latitude)
                ) && 
                (
                    DisplayName == other.DisplayName ||
                    DisplayName != null &&
                    DisplayName.Equals(other.DisplayName)
                ) && 
                (
                    Longitude == other.Longitude ||
                    Longitude != null &&
                    Longitude.Equals(other.Longitude)
                );
        }
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Latitude != null)
                    hashCode = hashCode * 59 + Latitude.GetHashCode();
                    if (DisplayName != null)
                    hashCode = hashCode * 59 + DisplayName.GetHashCode();
                    if (Longitude != null)
                    hashCode = hashCode * 59 + Longitude.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ActivitiesHistoryStartCity left, ActivitiesHistoryStartCity right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ActivitiesHistoryStartCity left, ActivitiesHistoryStartCity right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
